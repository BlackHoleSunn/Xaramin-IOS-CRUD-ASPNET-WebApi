using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using App3.Models;
using System.Threading.Tasks;


namespace App3
{
	partial class AddUserViewController : UIViewController
	{
		public AddUserViewController (IntPtr handle) : base (handle)
		{
		}

        private readonly UsersRepositry repository = new UsersRepositry();


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();




        }

        

        async partial void SaveUserBtn_TouchUpInside(UIButton sender)
        {

            Users p = new Users();
            p.Fullname = fullnametxt.Text;
            p.EmailAddress = EmailAddresstxt.Text;
            p.Password = PasswordTxt.Text;

            await SaveNewUser(p);

            



        }

        private async Task SaveNewUser(Users p)
        {
            var data = await repository.SaveNewUser(p);

            ViewController controller = this.Storyboard.InstantiateViewController("ViewController") as ViewController;
            this.NavigationController.PushViewController(controller, true);

        }











    }
}
