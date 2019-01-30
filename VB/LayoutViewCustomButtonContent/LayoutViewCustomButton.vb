Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraEditors

Namespace CustomButtonsLayoutView
	Public Class LayoutViewCustomButton
		Inherits LayoutView
		Public Sub New()
			Me.New(Nothing)
		End Sub

		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
			buttonsCollection_ = New CustomButtonCollection()
			AddHandler buttonsCollection_.OnCustomButtonClick, AddressOf buttonsCollection_OnCustomButtonClick
		End Sub

		Private Sub buttonsCollection_OnCustomButtonClick(ByVal sender As Object, ByVal e As CustomButtonEventsArgs)
			RaiseEvent CustomButtonClick(Me, e)
		End Sub


		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "LayoutViewCustomButton"
			End Get
		End Property

		Private buttonsCollection_ As CustomButtonCollection
		<Localizable(True), RefreshProperties(RefreshProperties.All), Description("Returns a collection of custom buttons in the LayoutView header panel."), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property ButtonsCollection() As CustomButtonCollection
			Get
				Return If(buttonsCollection_ Is Nothing, New CustomButtonCollection(), buttonsCollection_)
			End Get
		End Property

		' let's define delegate and event, fires wgen custom button pressed
		Public Delegate Sub LayoutViewCustomButtonEventHandler(ByVal sender As Object, ByVal e As CustomButtonEventsArgs)
		<Description("Fires when a custom button is pressed in the layout view."), Category(CategoryName.Events)> _
		Public Event CustomButtonClick As LayoutViewCustomButtonEventHandler
	End Class
End Namespace
