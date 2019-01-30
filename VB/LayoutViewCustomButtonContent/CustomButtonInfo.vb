Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.Layout.Drawing
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.Utils.Drawing
Imports System.Collections
Imports System.Windows.Forms

Namespace CustomButtonsLayoutView
	Public Class CustomViewButton
		Private Shared instanceCount As Integer = 0
		' protected members
		Protected buttonName_ As String
		Protected buttonBounds_ As Rectangle
		Protected buttonImage_ As Image
		Protected buttonWidth_ As Integer

		Public Sub New()
			Me.New("", Rectangle.Empty, Nothing, 0)
		End Sub
		Public Sub New(ByVal parName As String, ByVal parBounds As Rectangle, ByVal parImage As Image, ByVal parWidth As Integer)
			Name = parName
			buttonBounds_ = parBounds
			buttonImage_ = parImage
			buttonWidth_ = parWidth
		End Sub

		' public properties
		<Description("Button name. Gets or sets a name that is used to identify a button.")> _
		Public Property Name() As String
			Get
				Return buttonName_
			End Get
			Set(ByVal value As String)
				If value = "" Then
					instanceCount += 1
					buttonName_ = "Name" & instanceCount.ToString()
				Else
					buttonName_ = value
				End If

			End Set
		End Property

		<Description("Button width. Gets or sets a button's width. If a width is set to 0, a default button's width is used."), DefaultValue(0)> _
		Public Property Width() As Integer
			Get
				Return buttonWidth_
			End Get
			Set(ByVal value As Integer)
				If value >= 24 OrElse value = 0 Then
					buttonWidth_ = value
				End If
			End Set
		End Property

		<Description("Button image. Gets or sets an image that is shown within a button.")> _
		Public Property Image() As Image
			Get
				Return buttonImage_
			End Get
			Set(ByVal value As Image)
				buttonImage_ = value
			End Set
		End Property

		<Browsable(False)> _
		Public Property Bounds() As Rectangle
			Get
				Return buttonBounds_
			End Get
			Set(ByVal value As Rectangle)
				buttonBounds_ = value
			End Set
		End Property
		Public Overrides Function ToString() As String
			Return Name
		End Function
	End Class


	Public Class CustomButtonEventsArgs
		Inherits EventArgs
		Protected protCustomButton As CustomViewButton
		Public ReadOnly Property CustomButton() As CustomViewButton
			Get
				Return protCustomButton
			End Get
		End Property
		Public Sub New(ByVal paramButton As CustomViewButton)
			Me.protCustomButton = paramButton
		End Sub
	End Class

	<ListBindable(False), TypeConverter(GetType(DevExpress.Utils.Design.UniversalCollectionTypeConverter))> _
	Public Class CustomButtonCollection
		Inherits CollectionBase
		<Description("Gets a button at the specified position.")> _
		Default Public ReadOnly Property Item(ByVal index As Integer) As CustomViewButton
			Get
				Return TryCast(List(index), CustomViewButton)
			End Get
		End Property

		Public Overridable Function Add(ByVal button As CustomViewButton) As Integer
			Dim res As Integer = IndexOf(button)
			If res = -1 Then
				res = List.Add(button)
			End If
			Return res
		End Function
		Public Overridable Function IndexOf(ByVal button As CustomViewButton) As Integer
			Return List.IndexOf(button)
		End Function
		Public Overridable Function Contains(ByVal button As CustomViewButton) As Boolean
			Return List.Contains(button)
		End Function
		Public Overridable Sub Insert(ByVal index As Integer, ByVal button As CustomViewButton)
			If Contains(button) Then
				Return
			End If
			List.Insert(index, button)
		End Sub

		Public Overrides Function ToString() As String
			Return "Collection"
		End Function

		Public Sub CheckForCustomButtonClick(ByVal iButtonHashCode As Integer)
			For i As Integer = 0 To Count - 1
				Dim item As CustomViewButton = Me(i)
				If item.GetHashCode() = iButtonHashCode AndAlso OnCustomButtonClickEvent IsNot Nothing Then
					RaiseEvent OnCustomButtonClick(Me, New CustomButtonEventsArgs(TryCast(item, CustomViewButton)))
				End If
			Next i
		End Sub

		Public Delegate Sub SimpleButtonCollectionEvenrHandler(ByVal sender As Object, ByVal e As CustomButtonEventsArgs)
		<Browsable(False)> _
		Public Event OnCustomButtonClick As SimpleButtonCollectionEvenrHandler
	End Class
End Namespace
