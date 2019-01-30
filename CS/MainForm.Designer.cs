namespace CustomButtonsLayoutView
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            CustomButtonsLayoutView.CustomViewButton customViewButton1 = new CustomButtonsLayoutView.CustomViewButton();
            CustomButtonsLayoutView.CustomViewButton customViewButton2 = new CustomButtonsLayoutView.CustomViewButton();
            this.myGridControlMain = new CustomButtonsLayoutView.MyGridControl();
            this.layoutViewCustomButtonMain = new CustomButtonsLayoutView.LayoutViewCustomButton();
            this.repositoryItemPictureEditCommon = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemMemoEditCommon = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCustomButtonMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditCommon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditCommon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridControlMain
            // 
            this.myGridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControlMain.Location = new System.Drawing.Point(0, 0);
            this.myGridControlMain.MainView = this.layoutViewCustomButtonMain;
            this.myGridControlMain.Name = "myGridControlMain";
            this.myGridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEditCommon,
            this.repositoryItemMemoEditCommon});
            this.myGridControlMain.Size = new System.Drawing.Size(505, 486);
            this.myGridControlMain.TabIndex = 0;
            this.myGridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutViewCustomButtonMain});
            // 
            // layoutViewCustomButtonMain
            // 
            customViewButton1.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            customViewButton1.Image = global::CustomButtonsLayoutView.Properties.Resources.show_root;
            customViewButton1.Name = "Name1";
            customViewButton2.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            customViewButton2.Image = global::CustomButtonsLayoutView.Properties.Resources.category03;
            customViewButton2.Name = "Name2";
            customViewButton2.Width = 60;
            this.layoutViewCustomButtonMain.ButtonsCollection.Add(customViewButton1);
            this.layoutViewCustomButtonMain.ButtonsCollection.Add(customViewButton2);
            this.layoutViewCustomButtonMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2});
            this.layoutViewCustomButtonMain.GridControl = this.myGridControlMain;
            this.layoutViewCustomButtonMain.Name = "layoutViewCustomButtonMain";
            this.layoutViewCustomButtonMain.TemplateCard = this.layoutViewCard1;
            this.layoutViewCustomButtonMain.CustomButtonClick += new CustomButtonsLayoutView.LayoutViewCustomButton.LayoutViewCustomButtonEventHandler(this.layoutViewCustomButtonMain_CustomButtonClick);
            // 
            // repositoryItemPictureEditCommon
            // 
            this.repositoryItemPictureEditCommon.Name = "repositoryItemPictureEditCommon";
            this.repositoryItemPictureEditCommon.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // repositoryItemMemoEditCommon
            // 
            this.repositoryItemMemoEditCommon.Name = "repositoryItemMemoEditCommon";
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn2});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "layoutViewColumn1";
            this.layoutViewColumn1.FieldName = "ID";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(114, 20);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(97, 13);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "layoutViewColumn2";
            this.layoutViewColumn2.FieldName = "Name";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(114, 20);
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(97, 13);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 486);
            this.Controls.Add(this.myGridControlMain);
            this.Name = "MainForm";
            this.Text = "Application main form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCustomButtonMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditCommon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditCommon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MyGridControl myGridControlMain;
        private LayoutViewCustomButton layoutViewCustomButtonMain;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditCommon;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEditCommon;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn2;
    }
}

