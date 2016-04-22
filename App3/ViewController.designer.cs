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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton addUserBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton MovePagebtn { get; set; }

		[Action ("AddUserBtn_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void AddUserBtn_TouchUpInside (UIButton sender);

		[Action ("MovePagebtn_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void MovePagebtn_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (addUserBtn != null) {
				addUserBtn.Dispose ();
				addUserBtn = null;
			}
			if (MovePagebtn != null) {
				MovePagebtn.Dispose ();
				MovePagebtn = null;
			}
		}
	}
}
