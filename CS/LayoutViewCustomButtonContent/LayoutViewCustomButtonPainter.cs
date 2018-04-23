using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Layout.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using System.Drawing;

namespace CustomButtonsLayoutView
{
    class LayoutViewCustomButtonPainter : LayoutViewPainter
    {
        public LayoutViewCustomButtonPainter(BaseView view) : base(view) { }

        protected override void DrawHeader(DevExpress.XtraGrid.Views.Layout.ViewInfo.LayoutViewDrawArgs e)
        {
            if (!e.ViewInfo.ViewRects.HeaderRect.IsEmpty)
            {
                LayoutViewHeaderObjectInfoArgs info = new LayoutViewHeaderObjectInfoArgs(View);
                info.Bounds = e.ViewInfo.ViewRects.HeaderRect;
                info.SetAppearance(View.PaintAppearance.HeaderPanel);
                List<ButtonInfo> buttons = new List<ButtonInfo>();
                PrepareSingleModeButton(e, buttons);
                PrepareRowModeButton(e, buttons);
                PrepareColumnModeButton(e, buttons);
                PrepareMultiRowModeButton(e, buttons);
                PrepareMultiColumnModeButton(e, buttons);
                PrepareCarouselModeButton(e, buttons);
                if (View.OptionsBehavior.AllowPanCards) PreparePanButton(e, buttons);
                if (View.OptionsBehavior.AllowRuntimeCustomization) PrepareCustomizeButton(e, buttons);
                // add custom button collections of the current layout view
                PrepareCustomButtons(e, buttons);
                info.Buttons = buttons.ToArray();
                ObjectPainter.DrawObject(e.Cache, ElementsPainter.HeaderPanel, info);
                DrawHeaderSeparator(e);
                if (View.IsDetailView) DrawCloseZoomButton(e);
            }
        }

        protected virtual void PrepareCustomButtons(LayoutViewDrawArgs e, List<ButtonInfo> buttons)
        {
            LayoutViewCustomButton CurrentView = View as LayoutViewCustomButton;
            if (CurrentView == null) return;
            foreach (CustomViewButton item in CurrentView.ButtonsCollection)
            {
                if (item.Bounds != Rectangle.Empty)
                {
                    ButtonInfo buttonInfo = new ButtonInfo(item.Bounds, item.Image);
                    buttonInfo.State = CalcCustomButtonState(e, item.GetHashCode());
                    buttons.Add(buttonInfo);                    
                }
            }
        }

        public virtual ObjectState CalcCustomButtonState(LayoutViewDrawArgs e, int iCurrentHitTest)
        {
            ObjectState state = ObjectState.Normal;
            if (e.ViewInfo.SelectionInfo.HotTrackedInfo != null && (int)e.ViewInfo.SelectionInfo.HotTrackedInfo.HitTest == iCurrentHitTest) { state |= ObjectState.Hot; }
            return state;
        }
    }
}
