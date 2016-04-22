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
	[Register ("CostasViewController")]
	partial class CostasViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton deletebtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel emailaddresstxt { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel fullnametxt { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel idtxt { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel passwordtxt { get; set; }

		[Action ("Deletebtn_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Deletebtn_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (deletebtn != null) {
				deletebtn.Dispose ();
				deletebtn = null;
			}
			if (emailaddresstxt != null) {
				emailaddresstxt.Dispose ();
				emailaddresstxt = null;
			}
			if (fullnametxt != null) {
				fullnametxt.Dispose ();
				fullnametxt = null;
			}
			if (idtxt != null) {
				idtxt.Dispose ();
				idtxt = null;
			}
			if (passwordtxt != null) {
				passwordtxt.Dispose ();
				passwordtxt = null;
			}
		}
	}
}
