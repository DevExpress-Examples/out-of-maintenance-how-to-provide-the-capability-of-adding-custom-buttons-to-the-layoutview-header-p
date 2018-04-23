Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Layout.Drawing

Namespace CustomButtonsLayoutView
	Friend Class LayoutViewCustomButtonSkinPaintStyle
		Inherits DevExpress.XtraGrid.Registrator.LayoutViewSkinPaintStyle
		Public Overrides Function CreatePainter(ByVal view As BaseView) As DevExpress.XtraGrid.Views.Base.BaseViewPainter
			Return New LayoutViewCustomButtonPainter(view)
		End Function
	End Class
End Namespace
