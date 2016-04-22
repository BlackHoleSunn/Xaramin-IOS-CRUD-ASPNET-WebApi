using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using App3.Models;
using System.Threading.Tasks;
using ToastIOS;




namespace App3
{
	partial class CostasViewController : UIViewController
	{
        private readonly UsersRepositry repository = new UsersRepositry();



        public CostasViewController (IntPtr handle) : base (handle)
		{
        
		}

        public int UserID { get; set; }

        Users myuser = new Users();


        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            await LoadUsers();


            idtxt.Text = myuser.ID.ToString();
            fullnametxt.Text = myuser.Fullname;
            emailaddresstxt.Text = myuser.EmailAddress;
            passwordtxt.Text = myuser.Password;

        }


        private async Task LoadUsers()
        {
            var data = await repository.LoadSingleUser(UserID);
            myuser = data;
        }

                
        async partial void Deletebtn_TouchUpInside(UIButton sender)
        {

            await DeleteUser();


        }

        private async Task DeleteUser()
        {
            var data = await repository.DeleteUser(UserID);






            Toast.MakeText("Delete Successfull").SetDuration(4000).Show(ToastType.Info);




            ViewController controller = this.Storyboard.InstantiateViewController("ViewController") as ViewController;
            this.NavigationController.PushViewController(controller, true);

        }






    }
}
