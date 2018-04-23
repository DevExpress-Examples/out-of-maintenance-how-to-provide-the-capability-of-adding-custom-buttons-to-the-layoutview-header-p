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
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesDBDataSet = new CustomButtonsLayoutView.countriesDBDataSet();
            this.countriesTableAdapter = new CustomButtonsLayoutView.countriesDBDataSetTableAdapters.CountriesTableAdapter();
            this.myGridControlMain = new CustomButtonsLayoutView.MyGridControl();
            this.layoutViewCustomButtonMain = new CustomButtonsLayoutView.LayoutViewCustomButton();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCountry = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCountry = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colOfficialName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colOfficialName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCurrency = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCurrency = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCapital = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCapital = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBFlag = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEditCommon = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_colBFlag = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colArea = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colArea = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colGDP = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colGDP = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPopulation = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPopulation = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colLanguages = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemMemoEditCommon = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutViewField_colLanguages = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colReligions = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colReligions = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCustomButtonMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colOfficialName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditCommon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colGDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditCommon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLanguages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReligions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.countriesDBDataSet;
            // 
            // countriesDBDataSet
            // 
            this.countriesDBDataSet.DataSetName = "countriesDBDataSet";
            this.countriesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // myGridControlMain
            // 
            this.myGridControlMain.DataSource = this.countriesBindingSource;
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
            this.colId,
            this.colCountry,
            this.colOfficialName,
            this.colCurrency,
            this.colCapital,
            this.colBFlag,
            this.colArea,
            this.colGDP,
            this.colPopulation,
            this.colLanguages,
            this.colReligions});
            this.layoutViewCustomButtonMain.GridControl = this.myGridControlMain;
            this.layoutViewCustomButtonMain.Name = "layoutViewCustomButtonMain";
            this.layoutViewCustomButtonMain.TemplateCard = this.layoutViewCard1;
            this.layoutViewCustomButtonMain.CustomButtonClick += new CustomButtonsLayoutView.LayoutViewCustomButton.LayoutViewCustomButtonEventHandler(this.layoutViewCustomButtonMain_CustomButtonClick);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.LayoutViewField = this.layoutViewField_colId;
            this.colId.Name = "colId";
            // 
            // layoutViewField_colId
            // 
            this.layoutViewField_colId.EditorPreferredWidth = 128;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(67, 13);
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.LayoutViewField = this.layoutViewField_colCountry;
            this.colCountry.Name = "colCountry";
            // 
            // layoutViewField_colCountry
            // 
            this.layoutViewField_colCountry.EditorPreferredWidth = 128;
            this.layoutViewField_colCountry.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_colCountry.Name = "layoutViewField_colCountry";
            this.layoutViewField_colCountry.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colCountry.TextSize = new System.Drawing.Size(67, 13);
            // 
            // colOfficialName
            // 
            this.colOfficialName.FieldName = "OfficialName";
            this.colOfficialName.LayoutViewField = this.layoutViewField_colOfficialName;
            this.colOfficialName.Name = "colOfficialName";
            // 
            // layoutViewField_colOfficialName
            // 
            this.layoutViewField_colOfficialName.EditorPreferredWidth = 128;
            this.layoutViewField_colOfficialName.Location = new System.Drawing.Point(0, 40);
            this.layoutViewField_colOfficialName.Name = "layoutViewField_colOfficialName";
            this.layoutViewField_colOfficialName.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colOfficialName.TextSize = new System.Drawing.Size(67, 13);
            // 
            // colCurrency
            // 
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.LayoutViewField = this.layoutViewField_colCurrency;
            this.colCurrency.Name = "colCurrency";
            // 
            // layoutViewField_colCurrency
            // 
            this.layoutViewField_colCurrency.EditorPreferredWidth = 128;
            this.layoutViewField_colCurrency.Location = new System.Drawing.Point(0, 60);
            this.layoutViewField_colCurrency.Name = "layoutViewField_colCurrency";
            this.layoutViewField_colCurrency.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colCurrency.TextSize = new System.Drawing.Size(67, 13);
            // 
            // colCapital
            // 
            this.colCapital.FieldName = "Capital";
            this.colCapital.LayoutViewField = this.layoutViewField_colCapital;
            this.colCapital.Name = "colCapital";
            // 
            // layoutViewField_colCapital
            // 
            this.layoutViewField_colCapital.EditorPreferredWidth = 128;
            this.layoutViewField_colCapital.Location = new System.Drawing.Point(0, 80);
            this.layoutViewField_colCapital.Name = "layoutViewField_colCapital";
            this.layoutViewField_colCapital.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colCapital.TextSize = new System.Drawing.Size(67, 13);
            // 
            // colBFlag
            // 
            this.colBFlag.ColumnEdit = this.repositoryItemPictureEditCommon;
            this.colBFlag.FieldName = "BFlag";
            this.colBFlag.LayoutViewField = this.layoutViewField_colBFlag;
            this.colBFlag.Name = "colBFlag";
            // 
            // repositoryItemPictureEditCommon
            // 
            this.repositoryItemPictureEditCommon.Name = "repositoryItemPictureEditCommon";
            this.repositoryItemPictureEditCommon.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // layoutViewField_colBFlag
            // 
            this.layoutViewField_colBFlag.EditorPreferredWidth = 128;
            this.layoutViewField_colBFlag.Location = new System.Drawing.Point(0, 100);
            this.layoutViewField_colBFlag.Name = "layoutViewField_colBFlag";
            this.layoutViewField_colBFlag.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colBFlag.TextSize = new System.Drawing.Size(67, 13);
            // 
            // colArea
            // 
            this.colArea.FieldName = "Area";
            this.colArea.LayoutViewField = this.layoutViewField_colArea;
            this.colArea.Name = "colArea";
            // 
            // layoutViewField_colArea
            // 
            this.layoutViewField_colArea.EditorPreferredWidth = 128;
            this.layoutViewField_colArea.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colArea.Name = "layoutViewField_colArea";
            this.layoutViewField_colArea.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colArea.TextSize = new System.Drawing.Size(67, 13);
            // 
            // colGDP
            // 
            this.colGDP.FieldName = "GDP";
            this.colGDP.LayoutViewField = this.layoutViewField_colGDP;
            this.colGDP.Name = "colGDP";
            // 
            // layoutViewField_colGDP
            // 
            this.layoutViewField_colGDP.EditorPreferredWidth = 128;
            this.layoutViewField_colGDP.Location = new System.Drawing.Point(0, 140);
            this.layoutViewField_colGDP.Name = "layoutViewField_colGDP";
            this.layoutViewField_colGDP.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colGDP.TextSize = new System.Drawing.Size(67, 13);
            // 
            // colPopulation
            // 
            this.colPopulation.FieldName = "Population";
            this.colPopulation.LayoutViewField = this.layoutViewField_colPopulation;
            this.colPopulation.Name = "colPopulation";
            // 
            // layoutViewField_colPopulation
            // 
            this.layoutViewField_colPopulation.EditorPreferredWidth = 128;
            this.layoutViewField_colPopulation.Location = new System.Drawing.Point(0, 160);
            this.layoutViewField_colPopulation.Name = "layoutViewField_colPopulation";
            this.layoutViewField_colPopulation.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colPopulation.TextSize = new System.Drawing.Size(67, 13);
            // 
            // colLanguages
            // 
            this.colLanguages.ColumnEdit = this.repositoryItemMemoEditCommon;
            this.colLanguages.FieldName = "Languages";
            this.colLanguages.LayoutViewField = this.layoutViewField_colLanguages;
            this.colLanguages.Name = "colLanguages";
            // 
            // repositoryItemMemoEditCommon
            // 
            this.repositoryItemMemoEditCommon.Name = "repositoryItemMemoEditCommon";
            // 
            // layoutViewField_colLanguages
            // 
            this.layoutViewField_colLanguages.EditorPreferredWidth = 128;
            this.layoutViewField_colLanguages.Location = new System.Drawing.Point(0, 180);
            this.layoutViewField_colLanguages.Name = "layoutViewField_colLanguages";
            this.layoutViewField_colLanguages.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colLanguages.TextSize = new System.Drawing.Size(67, 13);
            // 
            // colReligions
            // 
            this.colReligions.ColumnEdit = this.repositoryItemMemoEditCommon;
            this.colReligions.FieldName = "Religions";
            this.colReligions.LayoutViewField = this.layoutViewField_colReligions;
            this.colReligions.Name = "colReligions";
            // 
            // layoutViewField_colReligions
            // 
            this.layoutViewField_colReligions.EditorPreferredWidth = 128;
            this.layoutViewField_colReligions.Location = new System.Drawing.Point(0, 200);
            this.layoutViewField_colReligions.Name = "layoutViewField_colReligions";
            this.layoutViewField_colReligions.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colReligions.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId,
            this.layoutViewField_colCountry,
            this.layoutViewField_colOfficialName,
            this.layoutViewField_colCurrency,
            this.layoutViewField_colCapital,
            this.layoutViewField_colBFlag,
            this.layoutViewField_colArea,
            this.layoutViewField_colGDP,
            this.layoutViewField_colPopulation,
            this.layoutViewField_colLanguages,
            this.layoutViewField_colReligions});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
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
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCustomButtonMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colOfficialName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCapital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditCommon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colGDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditCommon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLanguages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReligions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private countriesDBDataSet countriesDBDataSet;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private CustomButtonsLayoutView.countriesDBDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private MyGridControl myGridControlMain;
        private LayoutViewCustomButton layoutViewCustomButtonMain;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCountry;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCountry;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colOfficialName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colOfficialName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCurrency;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCurrency;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCapital;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCapital;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBFlag;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colBFlag;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colArea;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colArea;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colGDP;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colGDP;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPopulation;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPopulation;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colLanguages;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colLanguages;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colReligions;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colReligions;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditCommon;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEditCommon;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

