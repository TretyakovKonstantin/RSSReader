using System;

using UIKit;
using NativeButton;

namespace Test222222
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var burtton = new ButtonNew("test");
            burtton.Frame = new CoreGraphics.CGRect(40, 40, 50, 50);
            View.AddSubview(burtton);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
