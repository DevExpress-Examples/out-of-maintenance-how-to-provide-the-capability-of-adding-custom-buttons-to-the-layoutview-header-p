using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Layout.Drawing;

namespace CustomButtonsLayoutView
{
    class LayoutViewCustomButtonSkinPaintStyle : DevExpress.XtraGrid.Registrator.LayoutViewSkinPaintStyle
    {
        public override DevExpress.XtraGrid.Views.Base.BaseViewPainter CreatePainter(BaseView view)
        {
            return new LayoutViewCustomButtonPainter(view);
        }
    }
}
