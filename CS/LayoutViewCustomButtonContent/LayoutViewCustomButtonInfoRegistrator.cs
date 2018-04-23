using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.LookAndFeel;

namespace CustomButtonsLayoutView
{
    public class LayoutViewCustomButtonInfoRegistrator : LayoutViewInfoRegistrator
    {
        public override string ViewName { get { return "LayoutViewCustomButton"; } }
        public override BaseView CreateView(GridControl grid) { return new LayoutViewCustomButton(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new LayoutViewCustomButtonViewInfo(view as LayoutViewCustomButton); }
        public override BaseViewHandler CreateHandler(BaseView view) { return new LayoutViewCustomButtonHandler(view as LayoutViewCustomButton); }
        public override ViewPaintStyle PaintStyleByLookAndFeel(UserLookAndFeel lookAndFeel, string name) { return new LayoutViewCustomButtonSkinPaintStyle(); }
    }
}
