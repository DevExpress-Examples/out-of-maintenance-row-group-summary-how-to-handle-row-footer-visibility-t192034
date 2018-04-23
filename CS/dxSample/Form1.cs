using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Design;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            InitTreeList();
        }
        void InitTreeList() {
            InitData();
            InitSummary();
        }
        void InitData() {
            new XViews(treeList1);
        }
        void InitSummary(){
            treeList1.Columns[1].RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum;
            treeList1.Columns[2].RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Count;
        }
    }
}
