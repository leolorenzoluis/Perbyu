using System;

using UIKit;

namespace Perbyu.iOS
{
	public partial class ViewController : UIViewController
	{
		PinkViewController _pinkViewController;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void AwakeFromNib ()
		{
			_pinkViewController = Storyboard.InstantiateViewController ("PinkViewController") as PinkViewController;

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var okAlertController = UIAlertController.Create("Row Selected", UIAlertControllerStyle.Alert);
			okAlertController.AddAction (UIAlertAction.Create ("OK", UIAlertActionStyle.Default,null));
			PresentViewController (okAlertController, false, null);
			PinkButton.TouchUpInside += (sender, e) => {
				this.NavigationController.PushViewController(_pinkViewController,false);
			};

			TableButton.TouchUpInside += (sender, e) => {
				var tableViewController = Storyboard.InstantiateViewController("TableViewController") as TableViewController;
				this.NavigationController.PushViewController(tableViewController,false);
			};

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

