Imports Microsoft.VisualBasic
Imports System
Namespace CustomButtonsLayoutView
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim CustomViewButton1 As CustomButtonsLayoutView.CustomViewButton = New CustomButtonsLayoutView.CustomViewButton
            Dim CustomViewButton2 As CustomButtonsLayoutView.CustomViewButton = New CustomButtonsLayoutView.CustomViewButton
            Me.countriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.countriesDBDataSet = New CustomButtonsLayoutView.countriesDBDataSet
            Me.countriesTableAdapter = New CustomButtonsLayoutView.countriesDBDataSetTableAdapters.CountriesTableAdapter
            Me.myGridControlMain = New CustomButtonsLayoutView.MyGridControl
            Me.layoutViewCustomButtonMain = New CustomButtonsLayoutView.LayoutViewCustomButton
            Me.colId = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.layoutViewField_colId = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.colCountry = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.layoutViewField_colCountry = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.colOfficialName = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.layoutViewField_colOfficialName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.colCurrency = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.layoutViewField_colCurrency = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.colCapital = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.layoutViewField_colCapital = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.colBFlag = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.repositoryItemPictureEditCommon = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
            Me.layoutViewField_colBFlag = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.colArea = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.layoutViewField_colArea = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.colGDP = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.layoutViewField_colGDP = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.colPopulation = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.layoutViewField_colPopulation = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.colLanguages = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.repositoryItemMemoEditCommon = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
            Me.layoutViewField_colLanguages = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.colReligions = New DevExpress.XtraGrid.Columns.LayoutViewColumn
            Me.layoutViewField_colReligions = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.countriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.countriesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myGridControlMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewCustomButtonMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colId, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colCountry, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colOfficialName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colCapital, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPictureEditCommon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colBFlag, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colArea, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colGDP, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colPopulation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEditCommon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colReligions, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'countriesBindingSource
            '
            Me.countriesBindingSource.DataMember = "Countries"
            Me.countriesBindingSource.DataSource = Me.countriesDBDataSet
            '
            'countriesDBDataSet
            '
            Me.countriesDBDataSet.DataSetName = "countriesDBDataSet"
            Me.countriesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'countriesTableAdapter
            '
            Me.countriesTableAdapter.ClearBeforeFill = True
            '
            'myGridControlMain
            '
            Me.myGridControlMain.DataSource = Me.countriesBindingSource
            Me.myGridControlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myGridControlMain.Location = New System.Drawing.Point(0, 0)
            Me.myGridControlMain.MainView = Me.layoutViewCustomButtonMain
            Me.myGridControlMain.Name = "myGridControlMain"
            Me.myGridControlMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEditCommon, Me.repositoryItemMemoEditCommon})
            Me.myGridControlMain.Size = New System.Drawing.Size(505, 486)
            Me.myGridControlMain.TabIndex = 0
            Me.myGridControlMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.layoutViewCustomButtonMain})
            '
            'layoutViewCustomButtonMain
            '
            CustomViewButton1.Bounds = New System.Drawing.Rectangle(0, 0, 0, 0)
            CustomViewButton1.Image = Global.My.Resources.show_root
            CustomViewButton1.Name = "Name1"
            CustomViewButton2.Bounds = New System.Drawing.Rectangle(0, 0, 0, 0)
            CustomViewButton2.Image = Global.My.Resources.category03
            CustomViewButton2.Name = "Name2"
            CustomViewButton2.Width = 60
            Me.layoutViewCustomButtonMain.ButtonsCollection.Add(CustomViewButton1)
            Me.layoutViewCustomButtonMain.ButtonsCollection.Add(CustomViewButton2)
            Me.layoutViewCustomButtonMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colId, Me.colCountry, Me.colOfficialName, Me.colCurrency, Me.colCapital, Me.colBFlag, Me.colArea, Me.colGDP, Me.colPopulation, Me.colLanguages, Me.colReligions})
            Me.layoutViewCustomButtonMain.GridControl = Me.myGridControlMain
            Me.layoutViewCustomButtonMain.Name = "layoutViewCustomButtonMain"
            Me.layoutViewCustomButtonMain.TemplateCard = Me.layoutViewCard1
            '
            'colId
            '
            Me.colId.FieldName = "Id"
            Me.colId.LayoutViewField = Me.layoutViewField_colId
            Me.colId.Name = "colId"
            '
            'layoutViewField_colId
            '
            Me.layoutViewField_colId.EditorPreferredWidth = 128
            Me.layoutViewField_colId.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colId.Name = "layoutViewField_colId"
            Me.layoutViewField_colId.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colId.TextSize = New System.Drawing.Size(67, 13)
            '
            'colCountry
            '
            Me.colCountry.FieldName = "Country"
            Me.colCountry.LayoutViewField = Me.layoutViewField_colCountry
            Me.colCountry.Name = "colCountry"
            '
            'layoutViewField_colCountry
            '
            Me.layoutViewField_colCountry.EditorPreferredWidth = 128
            Me.layoutViewField_colCountry.Location = New System.Drawing.Point(0, 20)
            Me.layoutViewField_colCountry.Name = "layoutViewField_colCountry"
            Me.layoutViewField_colCountry.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colCountry.TextSize = New System.Drawing.Size(67, 13)
            '
            'colOfficialName
            '
            Me.colOfficialName.FieldName = "OfficialName"
            Me.colOfficialName.LayoutViewField = Me.layoutViewField_colOfficialName
            Me.colOfficialName.Name = "colOfficialName"
            '
            'layoutViewField_colOfficialName
            '
            Me.layoutViewField_colOfficialName.EditorPreferredWidth = 128
            Me.layoutViewField_colOfficialName.Location = New System.Drawing.Point(0, 40)
            Me.layoutViewField_colOfficialName.Name = "layoutViewField_colOfficialName"
            Me.layoutViewField_colOfficialName.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colOfficialName.TextSize = New System.Drawing.Size(67, 13)
            '
            'colCurrency
            '
            Me.colCurrency.FieldName = "Currency"
            Me.colCurrency.LayoutViewField = Me.layoutViewField_colCurrency
            Me.colCurrency.Name = "colCurrency"
            '
            'layoutViewField_colCurrency
            '
            Me.layoutViewField_colCurrency.EditorPreferredWidth = 128
            Me.layoutViewField_colCurrency.Location = New System.Drawing.Point(0, 60)
            Me.layoutViewField_colCurrency.Name = "layoutViewField_colCurrency"
            Me.layoutViewField_colCurrency.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colCurrency.TextSize = New System.Drawing.Size(67, 13)
            '
            'colCapital
            '
            Me.colCapital.FieldName = "Capital"
            Me.colCapital.LayoutViewField = Me.layoutViewField_colCapital
            Me.colCapital.Name = "colCapital"
            '
            'layoutViewField_colCapital
            '
            Me.layoutViewField_colCapital.EditorPreferredWidth = 128
            Me.layoutViewField_colCapital.Location = New System.Drawing.Point(0, 80)
            Me.layoutViewField_colCapital.Name = "layoutViewField_colCapital"
            Me.layoutViewField_colCapital.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colCapital.TextSize = New System.Drawing.Size(67, 13)
            '
            'colBFlag
            '
            Me.colBFlag.ColumnEdit = Me.repositoryItemPictureEditCommon
            Me.colBFlag.FieldName = "BFlag"
            Me.colBFlag.LayoutViewField = Me.layoutViewField_colBFlag
            Me.colBFlag.Name = "colBFlag"
            '
            'repositoryItemPictureEditCommon
            '
            Me.repositoryItemPictureEditCommon.Name = "repositoryItemPictureEditCommon"
            Me.repositoryItemPictureEditCommon.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            '
            'layoutViewField_colBFlag
            '
            Me.layoutViewField_colBFlag.EditorPreferredWidth = 128
            Me.layoutViewField_colBFlag.Location = New System.Drawing.Point(0, 100)
            Me.layoutViewField_colBFlag.Name = "layoutViewField_colBFlag"
            Me.layoutViewField_colBFlag.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colBFlag.TextSize = New System.Drawing.Size(67, 13)
            '
            'colArea
            '
            Me.colArea.FieldName = "Area"
            Me.colArea.LayoutViewField = Me.layoutViewField_colArea
            Me.colArea.Name = "colArea"
            '
            'layoutViewField_colArea
            '
            Me.layoutViewField_colArea.EditorPreferredWidth = 128
            Me.layoutViewField_colArea.Location = New System.Drawing.Point(0, 120)
            Me.layoutViewField_colArea.Name = "layoutViewField_colArea"
            Me.layoutViewField_colArea.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colArea.TextSize = New System.Drawing.Size(67, 13)
            '
            'colGDP
            '
            Me.colGDP.FieldName = "GDP"
            Me.colGDP.LayoutViewField = Me.layoutViewField_colGDP
            Me.colGDP.Name = "colGDP"
            '
            'layoutViewField_colGDP
            '
            Me.layoutViewField_colGDP.EditorPreferredWidth = 128
            Me.layoutViewField_colGDP.Location = New System.Drawing.Point(0, 140)
            Me.layoutViewField_colGDP.Name = "layoutViewField_colGDP"
            Me.layoutViewField_colGDP.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colGDP.TextSize = New System.Drawing.Size(67, 13)
            '
            'colPopulation
            '
            Me.colPopulation.FieldName = "Population"
            Me.colPopulation.LayoutViewField = Me.layoutViewField_colPopulation
            Me.colPopulation.Name = "colPopulation"
            '
            'layoutViewField_colPopulation
            '
            Me.layoutViewField_colPopulation.EditorPreferredWidth = 128
            Me.layoutViewField_colPopulation.Location = New System.Drawing.Point(0, 160)
            Me.layoutViewField_colPopulation.Name = "layoutViewField_colPopulation"
            Me.layoutViewField_colPopulation.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colPopulation.TextSize = New System.Drawing.Size(67, 13)
            '
            'colLanguages
            '
            Me.colLanguages.ColumnEdit = Me.repositoryItemMemoEditCommon
            Me.colLanguages.FieldName = "Languages"
            Me.colLanguages.LayoutViewField = Me.layoutViewField_colLanguages
            Me.colLanguages.Name = "colLanguages"
            '
            'repositoryItemMemoEditCommon
            '
            Me.repositoryItemMemoEditCommon.Name = "repositoryItemMemoEditCommon"
            '
            'layoutViewField_colLanguages
            '
            Me.layoutViewField_colLanguages.EditorPreferredWidth = 128
            Me.layoutViewField_colLanguages.Location = New System.Drawing.Point(0, 180)
            Me.layoutViewField_colLanguages.Name = "layoutViewField_colLanguages"
            Me.layoutViewField_colLanguages.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colLanguages.TextSize = New System.Drawing.Size(67, 13)
            '
            'colReligions
            '
            Me.colReligions.ColumnEdit = Me.repositoryItemMemoEditCommon
            Me.colReligions.FieldName = "Religions"
            Me.colReligions.LayoutViewField = Me.layoutViewField_colReligions
            Me.colReligions.Name = "colReligions"
            '
            'layoutViewField_colReligions
            '
            Me.layoutViewField_colReligions.EditorPreferredWidth = 128
            Me.layoutViewField_colReligions.Location = New System.Drawing.Point(0, 200)
            Me.layoutViewField_colReligions.Name = "layoutViewField_colReligions"
            Me.layoutViewField_colReligions.Size = New System.Drawing.Size(203, 20)
            Me.layoutViewField_colReligions.TextSize = New System.Drawing.Size(67, 13)
            '
            'layoutViewCard1
            '
            Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colId, Me.layoutViewField_colCountry, Me.layoutViewField_colOfficialName, Me.layoutViewField_colCurrency, Me.layoutViewField_colCapital, Me.layoutViewField_colBFlag, Me.layoutViewField_colArea, Me.layoutViewField_colGDP, Me.layoutViewField_colPopulation, Me.layoutViewField_colLanguages, Me.layoutViewField_colReligions})
            Me.layoutViewCard1.Name = "layoutViewTemplateCard"
            '
            'defaultLookAndFeel1
            '
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(505, 486)
            Me.Controls.Add(Me.myGridControlMain)
            Me.Name = "MainForm"
            Me.Text = "Application main form"
            CType(Me.countriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.countriesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myGridControlMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewCustomButtonMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colId, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colCountry, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colOfficialName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colCurrency, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colCapital, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPictureEditCommon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colBFlag, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colArea, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colGDP, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colPopulation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEditCommon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colLanguages, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colReligions, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private countriesDBDataSet As countriesDBDataSet
		Private countriesBindingSource As System.Windows.Forms.BindingSource
		Private countriesTableAdapter As CustomButtonsLayoutView.countriesDBDataSetTableAdapters.CountriesTableAdapter
		Private myGridControlMain As MyGridControl
		Private WithEvents layoutViewCustomButtonMain As LayoutViewCustomButton
		Private colId As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colId As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colCountry As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colCountry As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colOfficialName As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colOfficialName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colCurrency As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colCurrency As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colCapital As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colCapital As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colBFlag As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colBFlag As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colArea As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colArea As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colGDP As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colGDP As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colPopulation As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colPopulation As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colLanguages As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colLanguages As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colReligions As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colReligions As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private repositoryItemPictureEditCommon As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemMemoEditCommon As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
	End Class
End Namespace

