using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraTreeList;

namespace dxSample {
    class CustomTreeList : TreeList {
        protected override DevExpress.XtraTreeList.ViewInfo.TreeListViewInfo CreateViewInfo() {
            return new CustomTreeListViewInfo(this);
        }
    }
    

}
