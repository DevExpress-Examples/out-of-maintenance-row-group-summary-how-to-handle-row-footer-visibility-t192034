Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.ViewInfo

Namespace dxSample
    Friend Class CustomTreeListViewInfo
        Inherits TreeListViewInfo

        Public Sub New(ByVal tl As TreeList)
            MyBase.New(tl)
        End Sub
        Protected Overrides Sub CalcRowFooterInfo(ByVal rowIndex As Integer, ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal rowArgs As CalcRowGroupInfoArgs, ByVal even As Boolean)
            Dim lvl As Integer = node.Level
            If lvl = 2 Then
                Return
            End If
            MyBase.CalcRowFooterInfo(rowIndex, node, rowArgs, even)
        End Sub
    End Class
End Namespace
