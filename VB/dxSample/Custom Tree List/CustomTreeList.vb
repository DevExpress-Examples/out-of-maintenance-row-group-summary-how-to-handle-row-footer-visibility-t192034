Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraTreeList

Namespace dxSample
    Friend Class CustomTreeList
        Inherits TreeList

        Protected Overrides Function CreateViewInfo() As DevExpress.XtraTreeList.ViewInfo.TreeListViewInfo
            Return New CustomTreeListViewInfo(Me)
        End Function
    End Class


End Namespace
