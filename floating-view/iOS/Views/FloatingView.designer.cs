// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace iOS
{
	[Register ("FloatingView")]
	partial class FloatingView
	{
		[Outlet]
		UIKit.UIButton DismissButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DismissButton != null) {
				DismissButton.Dispose ();
				DismissButton = null;
			}
		}
	}
}
