using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Perbyu.iOS
{
	partial class TableViewController : UITableViewController
	{
		UITableView _table;

		public TableViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			_table = new UITableView(View.Bounds); // defaults to Plain style
			string[] tableItems = new string[] {"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers"};
			_table.Source = new TableSource(tableItems);
			Add (_table);
		}
	}
}
