Imports System
Imports System.Collections.Generic
Imports System.Drawing
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
        Protected Overrides Function CalcRowFooterInfo(ByVal fInfo As RowFooterInfo, ByVal bounds As System.Drawing.Rectangle, Optional ByVal isLast As Boolean = False) As Rectangle
            Dim lvl As Integer = fInfo.Node.Level
            If lvl = 2 Then
                Return bounds
            End If
            Return MyBase.CalcRowFooterInfo(fInfo, bounds, isLast)
        End Function
    End Class
End Namespace
