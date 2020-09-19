using System;
using System.Collections.Generic;
using CoreGraphics;

using UIKit;

namespace XamNativeLocalGalleryApp.iOS
{
    public partial class MainViewController : UIViewController
    {
        private UITableView _tableView;
        private TableSource _source;
        private ImageHandler _imageHandler;

        public MainViewController() : base("MainViewController", null)
        {
            _source = new TableSource();
            _imageHandler = new ImageHandler();
            _imageHandler.AssetsLoaded += handleAssetsLoaded;
        }

        private void handleAssetsLoaded(object sender, EventArgs e)
        {
            _source.UpdateGalleryItems(_imageHandler.CreateGalleryItems());
            _tableView.ReloadData();
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var width = View.Bounds.Width;
            var height = View.Bounds.Height;
            _tableView = new UITableView(new CGRect(0, 0, width, height));
            _tableView.AutoresizingMask = UIViewAutoresizing.All;
            _tableView.Source = _source;
            Add(_tableView);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

