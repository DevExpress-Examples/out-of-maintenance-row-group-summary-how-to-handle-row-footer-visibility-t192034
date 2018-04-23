using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.ViewInfo;

namespace dxSample {
    class CustomTreeListViewInfo : TreeListViewInfo {
        public CustomTreeListViewInfo(TreeList tl ):base(tl) {
        }
        protected override void CalcRowFooterInfo(int rowIndex, DevExpress.XtraTreeList.Nodes.TreeListNode node, CalcRowGroupInfoArgs rowArgs, bool even) {
            int lvl = node.Level;
            if(lvl == 2)
                return;
            base.CalcRowFooterInfo(rowIndex, node, rowArgs, even);
        }
    }
}
