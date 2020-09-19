using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace XamNativeLocalGalleryApp.iOS
{
    public class TableSource : UITableViewSource
    {
        protected List<GalleryItem> galleryItems;
        protected string cellIdentifier = "GalleryCell";

        public TableSource(string[] items)
        {
            galleryItems = new List<GalleryItem>();
        }

        public TableSource()
        {
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            throw new NotImplementedException();
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return galleryItems.Count;
        }

        
    }
}
