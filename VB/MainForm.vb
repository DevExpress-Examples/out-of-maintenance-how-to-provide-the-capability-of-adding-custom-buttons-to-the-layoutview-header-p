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
			' TODO: This line of code loads data into the 'countriesDBDataSet.Countries' table. You can move, or remove it, as needed.
			Me.countriesTableAdapter.Fill(Me.countriesDBDataSet.Countries)
		End Sub

		Private Sub layoutViewCustomButtonMain_CustomButtonClick(ByVal sender As Object, ByVal e As CustomButtonEventsArgs) Handles layoutViewCustomButtonMain.CustomButtonClick
			MessageBox.Show(e.CustomButton.Name)
		End Sub
	End Class
End Namespace
