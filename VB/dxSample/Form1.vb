Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Design

Namespace dxSample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            InitTreeList()
        End Sub
        Private Sub InitTreeList()
            InitData()
            InitSummary()
        End Sub
        Private Sub InitData()
            Dim tempVar As New XViews(treeList1)
        End Sub
        Private Sub InitSummary()
            treeList1.Columns(1).RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
            treeList1.Columns(2).RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Count
        End Sub
    End Class
End Namespace
