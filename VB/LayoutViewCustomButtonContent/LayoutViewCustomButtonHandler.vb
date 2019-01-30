Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.Layout.Handler
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraGrid.Views.Base.ViewInfo

Namespace CustomButtonsLayoutView
    Friend Class LayoutViewCustomButtonHandler
        Inherits LayoutViewHandler

        Public Sub New(ByVal gridView As LayoutView)
            MyBase.New(gridView)
        End Sub

        Public Overrides Sub DoClickAction(ByVal hitInfo As BaseHitInfo)
            MyBase.DoClickAction(hitInfo)
            Dim currentView As LayoutViewCustomButton = TryCast(View, LayoutViewCustomButton)
            Dim currentHitInfo As LayoutViewHitInfo = TryCast(hitInfo, LayoutViewHitInfo)
            currentView.ButtonsCollection.CheckForCustomButtonClick(CInt((currentHitInfo.HitTest)))
        End Sub
    End Class
End Namespace
