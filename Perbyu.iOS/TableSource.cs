using System;
using UIKit;
using Foundation;

namespace Perbyu.iOS
{
	public class TableSource : UITableViewSource {

		string[] TableItems;
		string CellIdentifier = "TableCell";

		TableViewController _tableViewController;

		public TableSource (string[] items, TableViewController tableViewController)
		{
			TableItems = items;
			_tableViewController = tableViewController;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return TableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
			string item = TableItems[indexPath.Row];

			//---- if there are no cells to reuse, create a new one
			if (cell == null)
			{ cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier); }

			cell.TextLabel.Text = item;

			return cell;
		}


		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			var okAlertController = UIAlertController.Create("Row Selected", TableItems[indexPath.Row], UIAlertControllerStyle.Alert);
			okAlertController.AddAction (UIAlertAction.Create ("OK", UIAlertActionStyle.Default,null));

			_tableViewController.PresentViewController (okAlertController, false, null);
			tableView.DeselectRow (indexPath, true);
		}

	}
}

