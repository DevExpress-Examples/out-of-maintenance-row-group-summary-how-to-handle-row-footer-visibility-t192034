# Row group summary - How to handle row footer visibility


This example demonstrates how to handle <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument1068">row footer</a> visibility.<br />Basically, such a <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument313">summary </a>item is displayed if the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraTreeListTreeListOptionsView_ShowRowFooterSummarytopic.aspx">TreeListOptionsView.ShowRowFooterSummary</a> option is enabled and can be specified for a column by using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListColumnsTreeListColumn_RowFooterSummarytopic">TreeListColumn.RowFooterSummary</a> property.<br />To manage row footer visibility, create a TreeList descendant and provide a custom TreeListViewInfo in the CreateViewInfo method. In the custom TreeListViewInfo class, override the CalcRowFooterInfo method to handle row footer displaying based on the <strong>information provided by this method</strong>, for example, based on the group level value provided by the node.Level property.<br /><br />In this example, a row footer for the second group level summary is hidden:<br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/row-group-summary-how-to-handle-row-footer-visibility-t192034/14.1.8+/media/209f0d27-902d-11e4-80ba-00155d624807.png">

<br/>


