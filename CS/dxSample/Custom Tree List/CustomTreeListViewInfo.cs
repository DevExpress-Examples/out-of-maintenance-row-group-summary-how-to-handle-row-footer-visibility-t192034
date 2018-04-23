using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.ViewInfo;

namespace dxSample {
    class CustomTreeListViewInfo : TreeListViewInfo {
        public CustomTreeListViewInfo(TreeList tl ):base(tl) {
        }
        protected override Rectangle CalcRowFooterInfo(RowFooterInfo fInfo, System.Drawing.Rectangle bounds, bool isLast = false) {
            int lvl = fInfo.Node.Level;
            if (lvl == 2)
                return bounds;
            return base.CalcRowFooterInfo(fInfo, bounds, isLast);
        }
    }
}
