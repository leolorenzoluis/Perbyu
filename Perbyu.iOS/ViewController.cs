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

			PinkButton.TouchUpInside += (sender, e) => {
				this.NavigationController.PushViewController(_pinkViewController,true);
			};

			TableButton.TouchUpInside += (sender, e) => {
				var tableViewController = Storyboard.InstantiateViewController("TableViewController") as TableViewController;
				this.NavigationController.PushViewController(tableViewController,true);
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

