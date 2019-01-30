Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid

Namespace CustomButtonsLayoutView
    Friend Class MyGridControl
        Inherits GridControl

        Protected Overrides Function CreateDefaultView() As DevExpress.XtraGrid.Views.Base.BaseView
            Return CreateView("LayoutViewCustomButton")
        End Function

        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As DevExpress.XtraGrid.Registrator.InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New LayoutViewCustomButtonInfoRegistrator())
        End Sub
    End Class
End Namespace
