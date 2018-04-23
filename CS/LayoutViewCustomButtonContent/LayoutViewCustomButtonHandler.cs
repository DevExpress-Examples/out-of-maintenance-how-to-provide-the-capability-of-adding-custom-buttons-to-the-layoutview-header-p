using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Layout.Handler;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace CustomButtonsLayoutView
{
    class LayoutViewCustomButtonHandler : LayoutViewHandler
    {
        public LayoutViewCustomButtonHandler(LayoutView gridView) : base(gridView) { }

        public override void DoClickAction(BaseHitInfo hitInfo)
        {
            base.DoClickAction(hitInfo);
            LayoutViewCustomButton currentView = View as LayoutViewCustomButton;
            LayoutViewHitInfo currentHitInfo = hitInfo as LayoutViewHitInfo;
            currentView.ButtonsCollection.CheckForCustomButtonClick((int)currentHitInfo.HitTest);
        }
    }
}
