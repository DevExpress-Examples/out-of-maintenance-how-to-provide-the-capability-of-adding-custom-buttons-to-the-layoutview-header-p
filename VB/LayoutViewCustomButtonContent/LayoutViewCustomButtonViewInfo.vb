Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Layout
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Base.ViewInfo

Namespace CustomButtonsLayoutView
    Public Class LayoutViewCustomButtonViewInfo
        Inherits LayoutViewInfo

        Public Sub New(ByVal gridView As LayoutView)
            MyBase.New(gridView)
        End Sub

        Protected Overrides Sub CalcButtonRects(ByVal buttonsRect As System.Drawing.Rectangle)
            Dim buttonSize As Size = Painter.ElementsPainter.HeaderPanel.GetButtonSize()
            Dim btnRects As New Stack(Of Rectangle)()
            Dim CurrentView As LayoutViewCustomButton = TryCast(Owner, LayoutViewCustomButton)
            Dim iCustomButtonsCount As Integer = 0
            If CurrentView IsNot Nothing Then
                iCustomButtonsCount = CurrentView.ButtonsCollection.Count
            End If
            For i As Integer = 8 + iCustomButtonsCount To 0 Step -1
                btnRects.Push(New Rectangle(buttonsRect.Location + New Size(i * (buttonSize.Width + 1), 0), buttonSize))
            Next i
            If View.OptionsHeaderPanel.ShowSingleModeButton Then
                ViewRects.SingleModeButton = btnRects.Pop()
            End If
            If View.OptionsHeaderPanel.ShowRowModeButton Then
                ViewRects.RowModeButton = btnRects.Pop()
            End If
            If View.OptionsHeaderPanel.ShowColumnModeButton Then
                ViewRects.ColumnModeButton = btnRects.Pop()
            End If
            If View.OptionsHeaderPanel.ShowMultiRowModeButton Then
                ViewRects.MultiRowModeButton = btnRects.Pop()
            End If
            If View.OptionsHeaderPanel.ShowMultiColumnModeButton Then
                ViewRects.MultiColumnModeButton = btnRects.Pop()
            End If
            If View.OptionsHeaderPanel.ShowCarouselModeButton Then
                ViewRects.CarouselModeButton = btnRects.Pop()
            End If
            If btnRects.Peek().Left <> buttonsRect.Left Then
                Dim separatorRect As Rectangle = btnRects.Pop()
                ViewRects.Separator = New Rectangle(separatorRect.Location + New Size(5, 3), New Size(6, buttonSize.Height - 6))
            End If
            If View.OptionsBehavior.AllowPanCards AndAlso View.OptionsHeaderPanel.ShowPanButton Then
                ViewRects.PanButton = btnRects.Pop()
            End If
            If View.OptionsBehavior.AllowRuntimeCustomization AndAlso View.OptionsHeaderPanel.ShowCustomizeButton Then
                ViewRects.CustomizeButton = btnRects.Pop()
            End If

            ' let's fill custom buttons rect
            Dim iWidthGap As Integer = 0
            For i As Integer = 0 To iCustomButtonsCount - 1
                Dim currentRect As Rectangle = btnRects.Pop()
                If CurrentView.ButtonsCollection(i).Width > 0 Then
                    CurrentView.ButtonsCollection(i).Bounds = New Rectangle(currentRect.X + iWidthGap, currentRect.Y, CurrentView.ButtonsCollection(i).Width, currentRect.Height)
                    iWidthGap += (CurrentView.ButtonsCollection(i).Width - currentRect.Width)
                Else
                    CurrentView.ButtonsCollection(i).Bounds = New Rectangle(currentRect.X + iWidthGap, currentRect.Y, currentRect.Width, currentRect.Height)
                End If
                If CurrentView.ButtonsCollection(i).Bounds.Right > buttonsRect.Right Then
                        Exit For
                End If
            Next i
            btnRects.Clear()
            btnRects = Nothing
            Dim clearBtnLeftBound As Integer = buttonsRect.Right
            If View.IsDetailView Then
                Dim closeZoomRect As New Rectangle(buttonsRect.Location + New Size(buttonsRect.Width - buttonSize.Width, 1), buttonSize)
                ViewRects.CloseZoomButton = closeZoomRect
                clearBtnLeftBound = closeZoomRect.Left
            End If
            If ViewRects.CustomizeButton.Right > clearBtnLeftBound Then
                ViewRects.ClearButtons()
            End If
        End Sub

        Public Overrides Function CalcHitInfo(ByVal pt As Point) As LayoutViewHitInfo
            Dim returnedValue As LayoutViewHitInfo = MyBase.CalcHitInfo(pt)
            Dim CurrentView As LayoutViewCustomButton = TryCast(Owner, LayoutViewCustomButton)
            If CurrentView IsNot Nothing Then
                For i As Integer = 1 To CurrentView.ButtonsCollection.Count
                    If CurrentView.ButtonsCollection(i - 1).Bounds.Contains(pt) Then
                        returnedValue.HitTest = CType(CurrentView.ButtonsCollection(i - 1).GetHashCode(), LayoutViewHitTest)
                        returnedValue.HitRect = CurrentView.ButtonsCollection(i - 1).Bounds
                    End If
                Next i
            End If
            Return returnedValue
        End Function

        Protected Overrides Function CreateSelectionInfo() As BaseSelectionInfo
            Return New LayoutViewCustomButtonSelectionInfo(TryCast(View, LayoutViewCustomButton))
        End Function
    End Class
End Namespace
