using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Layout.Drawing;
using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace CustomButtonsLayoutView
{
    public class CustomViewButton
    {
        static int instanceCount = 0;
        // protected members
        protected string buttonName_;
        protected Rectangle buttonBounds_;
        protected Image buttonImage_;
        protected int buttonWidth_;

        public CustomViewButton() : this("", Rectangle.Empty, null, 0) { }
        public CustomViewButton(string parName, Rectangle parBounds, Image parImage, int parWidth)
        {
            Name = parName;
            buttonBounds_ = parBounds;
            buttonImage_ = parImage;
            buttonWidth_ = parWidth;
        }

        // public properties
        [Description("Button name. Gets or sets a name that is used to identify a button.")]
        public string Name 
        { 
            get { return buttonName_; } 
            set 
            {
                if (value == "")
                {
                    instanceCount++;
                    buttonName_ = "Name" + instanceCount.ToString();
                }
                else
                {
                    buttonName_ = value; 
                }

            } 
        }

        [Description("Button width. Gets or sets a button's width. If a width is set to 0, a default button's width is used."), DefaultValue(0)]
        public int Width { get { return buttonWidth_; } set { if (value >= 24 || value == 0) buttonWidth_ = value; } }

        [Description("Button image. Gets or sets an image that is shown within a button.")]
        public Image Image { get { return buttonImage_; } set { buttonImage_ = value; } }

        [Browsable(false)]
        public Rectangle Bounds { get { return buttonBounds_; } set { buttonBounds_ = value; } }
        public override string ToString() { return Name; }
    }


    public class CustomButtonEventsArgs : EventArgs
    {
        protected CustomViewButton protCustomButton;
        public CustomViewButton CustomButton { get { return protCustomButton; } }
        public CustomButtonEventsArgs(CustomViewButton paramButton)
        {
            this.protCustomButton = paramButton;
        }
    }

    [ListBindable(false), TypeConverter(typeof(DevExpress.Utils.Design.UniversalCollectionTypeConverter))]
    public class CustomButtonCollection : CollectionBase
    {
        [Description("Gets a button at the specified position.")]
        public CustomViewButton this[int index] { get { return List[index] as CustomViewButton; } }

        public virtual int Add(CustomViewButton button)
        {
            int res = IndexOf(button);
            if (res == -1) res = List.Add(button);
            return res;
        }
        public virtual int IndexOf(CustomViewButton button) { return List.IndexOf(button); }
        public virtual bool Contains(CustomViewButton button) { return List.Contains(button); }
        public virtual void Insert(int index, CustomViewButton button)
        {
            if (Contains(button)) return;
            List.Insert(index, button);
        }

        public override string ToString()
        {
            return "Collection";
        }

        public void CheckForCustomButtonClick(int iButtonHashCode)
        {
            for (int i = 0; i < Count; i++)
            {
                CustomViewButton item = this[i];
                if (item.GetHashCode() == iButtonHashCode && OnCustomButtonClick != null)
                {
                    OnCustomButtonClick(this, new CustomButtonEventsArgs(item as CustomViewButton));
                }    
            }        
        }

        public delegate void SimpleButtonCollectionEvenrHandler(object sender, CustomButtonEventsArgs e);
        [Browsable(false)]
        public event SimpleButtonCollectionEvenrHandler OnCustomButtonClick;
    }
}
