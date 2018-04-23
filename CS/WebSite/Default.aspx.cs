using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxTreeList;
using System.Collections;
using System.Web.UI.MobileControls;

public partial class _Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		treeList.DataBind();		
	}


	protected void atlSelection_DataBinding(object sender, EventArgs e) {
		(sender as ASPxTreeList).DataSource = CreateLeftListDataSource();
	}	
	private IEnumerable CreateLeftListDataSource() {
		List<object> l = new List<object>();
		for (int i = 0; i < 3; i++) {
			l.Add(new { ItemId = i, Code = "Code " + i, Name = "Name " + i, Description = "Description " + i, ItemType = i % 3, ParentId = i % 10, Price = i * 10.00, });
		}
		return l;
	}
}