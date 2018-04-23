using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Layout;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace CustomButtonsLayoutView
{
    public class LayoutViewCustomButtonViewInfo : LayoutViewInfo
    {
        public LayoutViewCustomButtonViewInfo(LayoutView gridView) : base(gridView) { }

        protected override void CalcButtonRects(System.Drawing.Rectangle buttonsRect)
        {
            Size buttonSize = Painter.ElementsPainter.HeaderPanel.GetButtonSize();
            Stack<Rectangle> btnRects = new Stack<Rectangle>();
            LayoutViewCustomButton CurrentView = Owner as LayoutViewCustomButton;
            int iCustomButtonsCount = 0;
            if (CurrentView != null)
            {
                iCustomButtonsCount = CurrentView.ButtonsCollection.Count;
            }
            for (int i = 8 + iCustomButtonsCount; i >= 0; i--) btnRects.Push(
                     new Rectangle(buttonsRect.Location + new Size(i * (buttonSize.Width + 1), 0), buttonSize)
                 );
            if (View.OptionsHeaderPanel.ShowSingleModeButton) ViewRects.SingleModeButton = btnRects.Pop();
            if (View.OptionsHeaderPanel.ShowRowModeButton) ViewRects.RowModeButton = btnRects.Pop();
            if (View.OptionsHeaderPanel.ShowColumnModeButton) ViewRects.ColumnModeButton = btnRects.Pop();
            if (View.OptionsHeaderPanel.ShowMultiRowModeButton) ViewRects.MultiRowModeButton = btnRects.Pop();
            if (View.OptionsHeaderPanel.ShowMultiColumnModeButton) ViewRects.MultiColumnModeButton = btnRects.Pop();
            if (View.OptionsHeaderPanel.ShowCarouselModeButton) ViewRects.CarouselModeButton = btnRects.Pop();
            if (btnRects.Peek().Left != buttonsRect.Left)
            {
                Rectangle separatorRect = btnRects.Pop();
                ViewRects.Separator = new Rectangle(separatorRect.Location + new Size(5, 3), new Size(6, buttonSize.Height - 6));
            }
            if (View.OptionsBehavior.AllowPanCards && View.OptionsHeaderPanel.ShowPanButton) ViewRects.PanButton = btnRects.Pop();
            if (View.OptionsBehavior.AllowRuntimeCustomization && View.OptionsHeaderPanel.ShowCustomizeButton) ViewRects.CustomizeButton = btnRects.Pop();

            // let's fill custom buttons rect
            int iWidthGap = 0;
            for (int i = 0; i < iCustomButtonsCount; i++)
            {
                Rectangle currentRect = btnRects.Pop();
                if (CurrentView.ButtonsCollection[i].Width > 0) 
                { 
                    CurrentView.ButtonsCollection[i].Bounds = new Rectangle(currentRect.X + iWidthGap, currentRect.Y, CurrentView.ButtonsCollection[i].Width, currentRect.Height);
                    iWidthGap += (CurrentView.ButtonsCollection[i].Width - currentRect.Width); 
                }
                else CurrentView.ButtonsCollection[i].Bounds = new Rectangle(currentRect.X + iWidthGap, currentRect.Y, currentRect.Width, currentRect.Height);
                if (CurrentView.ButtonsCollection[i].Bounds.Right > buttonsRect.Right) 
                    { break; }
            }
            btnRects.Clear();
            btnRects = null;
            int clearBtnLeftBound = buttonsRect.Right;
            if (View.IsDetailView)
            {
                Rectangle closeZoomRect = new Rectangle(buttonsRect.Location + new Size(buttonsRect.Width - buttonSize.Width, 1), buttonSize);
                ViewRects.CloseZoomButton = closeZoomRect;
                clearBtnLeftBound = closeZoomRect.Left;
            }
            if (ViewRects.CustomizeButton.Right > clearBtnLeftBound) ViewRects.ClearButtons();
        }

        public override LayoutViewHitInfo CalcHitInfo(Point pt)
        {
            LayoutViewHitInfo returnedValue = base.CalcHitInfo(pt);
            LayoutViewCustomButton CurrentView = Owner as LayoutViewCustomButton;
            if (CurrentView != null)
            {
                for (int i = 1; i <= CurrentView.ButtonsCollection.Count; i++)
                {
                    if (CurrentView.ButtonsCollection[i - 1].Bounds.Contains(pt))
                    {
                        returnedValue.HitTest = (LayoutViewHitTest)CurrentView.ButtonsCollection[i - 1].GetHashCode();
                        returnedValue.HitRect = CurrentView.ButtonsCollection[i - 1].Bounds;
                    }
                }
            }
            return returnedValue;
        }

        protected override BaseSelectionInfo CreateSelectionInfo()
        {
            return new LayoutViewCustomButtonSelectionInfo(View as LayoutViewCustomButton);
        }
    }
}
