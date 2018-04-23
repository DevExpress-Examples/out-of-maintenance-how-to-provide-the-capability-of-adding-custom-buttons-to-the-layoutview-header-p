Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.Layout.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports System.Drawing

Namespace CustomButtonsLayoutView
	Friend Class LayoutViewCustomButtonPainter
		Inherits LayoutViewPainter
		Public Sub New(ByVal view As BaseView)
			MyBase.New(view)
		End Sub

		Protected Overrides Sub DrawHeader(ByVal e As DevExpress.XtraGrid.Views.Layout.ViewInfo.LayoutViewDrawArgs)
			If (Not e.ViewInfo.ViewRects.HeaderRect.IsEmpty) Then
				Dim info As New LayoutViewHeaderObjectInfoArgs(View)
				info.Bounds = e.ViewInfo.ViewRects.HeaderRect
				info.SetAppearance(View.PaintAppearance.HeaderPanel)
				Dim buttons As New List(Of ButtonInfo)()
				PrepareSingleModeButton(e, buttons)
				PrepareRowModeButton(e, buttons)
				PrepareColumnModeButton(e, buttons)
				PrepareMultiRowModeButton(e, buttons)
				PrepareMultiColumnModeButton(e, buttons)
				PrepareCarouselModeButton(e, buttons)
				If View.OptionsBehavior.AllowPanCards Then
					PreparePanButton(e, buttons)
				End If
				If View.OptionsBehavior.AllowRuntimeCustomization Then
					PrepareCustomizeButton(e, buttons)
				End If
				' add custom button collections of the current layout view
				PrepareCustomButtons(e, buttons)
				info.Buttons = buttons.ToArray()
				ObjectPainter.DrawObject(e.Cache, ElementsPainter.HeaderPanel, info)
				DrawHeaderSeparator(e)
				If View.IsDetailView Then
					DrawCloseZoomButton(e)
				End If
			End If
		End Sub

		Protected Overridable Sub PrepareCustomButtons(ByVal e As LayoutViewDrawArgs, ByVal buttons As List(Of ButtonInfo))
			Dim CurrentView As LayoutViewCustomButton = TryCast(View, LayoutViewCustomButton)
			If CurrentView Is Nothing Then
				Return
			End If
			For Each item As CustomViewButton In CurrentView.ButtonsCollection
				If item.Bounds <> Rectangle.Empty Then
					Dim buttonInfo As New ButtonInfo(item.Bounds, item.Image)
					buttonInfo.State = CalcCustomButtonState(e, item.GetHashCode())
					buttons.Add(buttonInfo)
				End If
			Next item
		End Sub

		Public Overridable Function CalcCustomButtonState(ByVal e As LayoutViewDrawArgs, ByVal iCurrentHitTest As Integer) As ObjectState
			Dim state As ObjectState = ObjectState.Normal
			If e.ViewInfo.SelectionInfo.HotTrackedInfo IsNot Nothing AndAlso CInt(Fix(e.ViewInfo.SelectionInfo.HotTrackedInfo.HitTest)) = iCurrentHitTest Then
				state = state Or ObjectState.Hot
			End If
			Return state
		End Function
	End Class
End Namespace
