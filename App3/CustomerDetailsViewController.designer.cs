// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace App3
{
	[Register ("CustomerDetailsViewController")]
	partial class CustomerDetailsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel userlbl { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (userlbl != null) {
				userlbl.Dispose ();
				userlbl = null;
			}
		}
	}
}
