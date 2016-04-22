using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace App3
{
	partial class CustomerDetailsViewController : UIViewController
	{
        private int iD;

        public CustomerDetailsViewController(int iD)
        {
            this.iD = iD;
        }

     
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

           


          //  userlbl.Text = "This is the correct page";

            

        }
    }
}
