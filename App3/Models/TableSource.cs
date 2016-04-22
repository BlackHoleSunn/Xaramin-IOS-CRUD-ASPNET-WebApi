using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Foundation;
using App3.Models;
using Xamarin.Themes;





namespace App3.Models
{
    class TableSource : UITableViewSource
    {
        public IList<Users> Entries { get; set; }
        private const string ValueCell = "ID";
        UIViewController parentController;
        

        public TableSource(IEnumerable<Users> entries, UIViewController myViewController)

        {
            Entries = new List<Users>(entries);
            parentController = myViewController;
         
        }

       
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var entry = Entries[indexPath.Row];
           
            UIStoryboard story = UIStoryboard.FromName("Main", null);
    
            CostasViewController controller = (UIViewController)story.InstantiateViewController("CostasViewController") as CostasViewController;

            controller.UserID = entry.ID;
            
            parentController.NavigationController.PushViewController(controller, true);
          
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(ValueCell) ??
                      new UITableViewCell(UITableViewCellStyle.Subtitle, ValueCell);


           


            var entry = Entries[indexPath.Row];
            cell.TextLabel.Text = entry.Fullname;
            cell.DetailTextLabel.Text = string.Format("Posted by {0} with {1} points", entry.EmailAddress, entry.Password);

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Entries.Count;
        }
    }
}
