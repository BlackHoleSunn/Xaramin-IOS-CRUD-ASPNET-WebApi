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
	[Register ("AddUserViewController")]
	partial class AddUserViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField EmailAddresstxt { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField fullnametxt { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField PasswordTxt { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SaveUserBtn { get; set; }

		[Action ("SaveUserBtn_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SaveUserBtn_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (EmailAddresstxt != null) {
				EmailAddresstxt.Dispose ();
				EmailAddresstxt = null;
			}
			if (fullnametxt != null) {
				fullnametxt.Dispose ();
				fullnametxt = null;
			}
			if (PasswordTxt != null) {
				PasswordTxt.Dispose ();
				PasswordTxt = null;
			}
			if (SaveUserBtn != null) {
				SaveUserBtn.Dispose ();
				SaveUserBtn = null;
			}
		}
	}
}
