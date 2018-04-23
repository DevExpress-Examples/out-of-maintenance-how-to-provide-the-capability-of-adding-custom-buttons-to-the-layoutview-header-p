using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraEditors;

namespace CustomButtonsLayoutView
{
    public class LayoutViewCustomButton : LayoutView
    {
        public LayoutViewCustomButton() : this(null) { }

        public LayoutViewCustomButton(GridControl grid) : base(grid) 
        { 
            buttonsCollection_ = new CustomButtonCollection();
            buttonsCollection_.OnCustomButtonClick += new CustomButtonCollection.SimpleButtonCollectionEvenrHandler(buttonsCollection_OnCustomButtonClick);
        }

        void buttonsCollection_OnCustomButtonClick(object sender, CustomButtonEventsArgs e)
        {
            if (CustomButtonClick != null)
            {
                CustomButtonClick(this, e);
            }
        }


        protected override string ViewName { get { return "LayoutViewCustomButton"; } }

        CustomButtonCollection buttonsCollection_;
        [Localizable(true), RefreshProperties(RefreshProperties.All), Description("Returns a collection of custom buttons in the LayoutView header panel."),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CustomButtonCollection ButtonsCollection
        {
            get 
            {
                return buttonsCollection_ == null ? new CustomButtonCollection() : buttonsCollection_; 
            }
        }

        // let's define delegate and event, fires wgen custom button pressed
        public delegate void LayoutViewCustomButtonEventHandler(object sender, CustomButtonEventsArgs e);
        [Description("Fires when a custom button is pressed in the layout view."), Category(CategoryName.Events)]
        public event LayoutViewCustomButtonEventHandler CustomButtonClick;
    }
}
