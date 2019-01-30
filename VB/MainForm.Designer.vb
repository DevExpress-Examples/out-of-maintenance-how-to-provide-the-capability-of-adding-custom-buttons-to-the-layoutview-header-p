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
			Me.components = New System.ComponentModel.Container()
			Dim customViewButton1 As New CustomButtonsLayoutView.CustomViewButton()
			Dim customViewButton2 As New CustomButtonsLayoutView.CustomViewButton()
			Me.myGridControlMain = New CustomButtonsLayoutView.MyGridControl()
			Me.layoutViewCustomButtonMain = New CustomButtonsLayoutView.LayoutViewCustomButton()
			Me.repositoryItemPictureEditCommon = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.repositoryItemMemoEditCommon = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.layoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewColumn2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_layoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			CType(Me.myGridControlMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCustomButtonMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEditCommon, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEditCommon, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myGridControlMain
			' 
			Me.myGridControlMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControlMain.Location = New System.Drawing.Point(0, 0)
			Me.myGridControlMain.MainView = Me.layoutViewCustomButtonMain
			Me.myGridControlMain.Name = "myGridControlMain"
			Me.myGridControlMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEditCommon, Me.repositoryItemMemoEditCommon})
			Me.myGridControlMain.Size = New System.Drawing.Size(505, 486)
			Me.myGridControlMain.TabIndex = 0
			Me.myGridControlMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutViewCustomButtonMain})
			' 
			' layoutViewCustomButtonMain
			' 
			customViewButton1.Bounds = New System.Drawing.Rectangle(0, 0, 0, 0)
			customViewButton1.Image = My.Resources.show_root
			customViewButton1.Name = "Name1"
			customViewButton2.Bounds = New System.Drawing.Rectangle(0, 0, 0, 0)
			customViewButton2.Image = My.Resources.category03
			customViewButton2.Name = "Name2"
			customViewButton2.Width = 60
			Me.layoutViewCustomButtonMain.ButtonsCollection.Add(customViewButton1)
			Me.layoutViewCustomButtonMain.ButtonsCollection.Add(customViewButton2)
			Me.layoutViewCustomButtonMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.layoutViewColumn1, Me.layoutViewColumn2})
			Me.layoutViewCustomButtonMain.GridControl = Me.myGridControlMain
			Me.layoutViewCustomButtonMain.Name = "layoutViewCustomButtonMain"
			Me.layoutViewCustomButtonMain.TemplateCard = Me.layoutViewCard1
'			Me.layoutViewCustomButtonMain.CustomButtonClick += New CustomButtonsLayoutView.LayoutViewCustomButton.LayoutViewCustomButtonEventHandler(Me.layoutViewCustomButtonMain_CustomButtonClick);
			' 
			' repositoryItemPictureEditCommon
			' 
			Me.repositoryItemPictureEditCommon.Name = "repositoryItemPictureEditCommon"
			Me.repositoryItemPictureEditCommon.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
			' 
			' repositoryItemMemoEditCommon
			' 
			Me.repositoryItemMemoEditCommon.Name = "repositoryItemMemoEditCommon"
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_layoutViewColumn1, Me.layoutViewField_layoutViewColumn2})
			Me.layoutViewCard1.Name = "layoutViewTemplateCard"
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' layoutViewColumn1
			' 
			Me.layoutViewColumn1.Caption = "layoutViewColumn1"
			Me.layoutViewColumn1.FieldName = "ID"
			Me.layoutViewColumn1.LayoutViewField = Me.layoutViewField_layoutViewColumn1
			Me.layoutViewColumn1.Name = "layoutViewColumn1"
			' 
			' layoutViewField_layoutViewColumn1
			' 
			Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 10
			Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
			Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(114, 20)
			Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(97, 13)
			' 
			' layoutViewColumn2
			' 
			Me.layoutViewColumn2.Caption = "layoutViewColumn2"
			Me.layoutViewColumn2.FieldName = "Name"
			Me.layoutViewColumn2.LayoutViewField = Me.layoutViewField_layoutViewColumn2
			Me.layoutViewColumn2.Name = "layoutViewColumn2"
			' 
			' layoutViewField_layoutViewColumn2
			' 
			Me.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 10
			Me.layoutViewField_layoutViewColumn2.Location = New System.Drawing.Point(0, 20)
			Me.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2"
			Me.layoutViewField_layoutViewColumn2.Size = New System.Drawing.Size(114, 20)
			Me.layoutViewField_layoutViewColumn2.TextSize = New System.Drawing.Size(97, 13)
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(505, 486)
			Me.Controls.Add(Me.myGridControlMain)
			Me.Name = "MainForm"
			Me.Text = "Application main form"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			CType(Me.myGridControlMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCustomButtonMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEditCommon, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEditCommon, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private myGridControlMain As MyGridControl
		Private WithEvents layoutViewCustomButtonMain As LayoutViewCustomButton
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private repositoryItemPictureEditCommon As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemMemoEditCommon As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private layoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_layoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewColumn2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_layoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
	End Class
End Namespace

