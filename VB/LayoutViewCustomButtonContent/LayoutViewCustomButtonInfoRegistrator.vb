Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.LookAndFeel

Namespace CustomButtonsLayoutView
	Public Class LayoutViewCustomButtonInfoRegistrator
		Inherits LayoutViewInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "LayoutViewCustomButton"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New LayoutViewCustomButton(TryCast(grid, GridControl))
		End Function
		Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
			Return New LayoutViewCustomButtonViewInfo(TryCast(view, LayoutViewCustomButton))
		End Function
		Public Overrides Function CreateHandler(ByVal view As BaseView) As BaseViewHandler
			Return New LayoutViewCustomButtonHandler(TryCast(view, LayoutViewCustomButton))
		End Function
		Public Overrides Function PaintStyleByLookAndFeel(ByVal lookAndFeel As UserLookAndFeel, ByVal name As String) As ViewPaintStyle
			Return New LayoutViewCustomButtonSkinPaintStyle()
		End Function
	End Class
End Namespace
