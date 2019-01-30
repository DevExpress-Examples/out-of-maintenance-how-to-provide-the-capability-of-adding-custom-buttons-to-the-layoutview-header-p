Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace CustomButtonsLayoutView
	Partial Public Class MainForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim list = New BindingList(Of Customer)()
			For i As Integer = 0 To 9
				list.Add(New Customer() With {.ID = i, .Name = "Name" & i})
			Next i
			myGridControlMain.DataSource = list
		End Sub

		Private Sub layoutViewCustomButtonMain_CustomButtonClick(ByVal sender As Object, ByVal e As CustomButtonEventsArgs) Handles layoutViewCustomButtonMain.CustomButtonClick
			MessageBox.Show(e.CustomButton.Name)
		End Sub
	End Class
	Public Class Customer
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class
End Namespace
