using System;
using App3.Models;
using System.Linq;

using UIKit;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Themes;


namespace App3
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        private readonly UsersRepositry repository = new UsersRepositry();
        private TableSource source;
        UITableView _table;



        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            await LoadEntriesAsync();


         

            View.AddSubview(_table);

        }

       

        private async Task LoadEntriesAsync()
        {
            var data = await repository.GetAllUsersRepository();

           // source.Entries = mysource.Entries;
            var mysource = new List<Users>(data);


            _table = new UITableView
            {
                Frame = new CoreGraphics.CGRect(0, 100, View.Bounds.Width, View.Bounds.Height - 50),
                Source = new TableSource(mysource, this)


            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

       


        partial void AddUserBtn_TouchUpInside(UIButton sender)
        {

            AddUserViewController controller = this.Storyboard.InstantiateViewController("AddUserViewController") as AddUserViewController;
            this.NavigationController.PushViewController(controller, true);







        }
    }
}