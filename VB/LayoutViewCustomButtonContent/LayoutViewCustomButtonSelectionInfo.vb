Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout

Namespace CustomButtonsLayoutView
    Friend Class LayoutViewCustomButtonSelectionInfo
        Inherits LayoutViewSelectionInfo

        Public Sub New(ByVal gridView As LayoutViewCustomButton)
            MyBase.New(gridView)
            If gridView IsNot Nothing AndAlso gridView.ButtonsCollection.Count > 0 Then
                Dim myValidHotTracks((fValidHotTracks.Length + gridView.ButtonsCollection.Count) - 1) As Integer
                Dim myValidPressedHitTests((fValidHotTracks.Length + gridView.ButtonsCollection.Count) - 1) As Integer
                Dim myViewPressedStates((fValidHotTracks.Length + gridView.ButtonsCollection.Count) - 1) As Integer
                Array.Copy(fValidHotTracks, myValidHotTracks, fValidHotTracks.Length)
                Array.Copy(fValidPressedHitTests, myValidPressedHitTests, fValidPressedHitTests.Length)
                Array.Copy(fViewPressedStates, myViewPressedStates, fViewPressedStates.Length)
                For i As Integer = 1 To gridView.ButtonsCollection.Count
                    myValidHotTracks(fValidHotTracks.Length - 1 + i) = gridView.ButtonsCollection(i - 1).GetHashCode()
                    myValidPressedHitTests(fValidPressedHitTests.Length - 1 + i) = gridView.ButtonsCollection(i - 1).GetHashCode()
                    myViewPressedStates(fViewPressedStates.Length - 1 + i) = gridView.ButtonsCollection(i - 1).GetHashCode()
                Next i
                fValidHotTracks = myValidHotTracks
                fValidPressedHitTests = myValidPressedHitTests
                fViewPressedStates = myViewPressedStates
            End If
        End Sub
    End Class
End Namespace
