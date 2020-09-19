using System;
using Foundation;
using UIKit;

namespace XamNativeLocalGalleryApp.iOS
{
    public class GalleryCell : UITableViewCell
    {
        private UIImageView _imageView;
        private UILabel _titleLabel;
        private UILabel _dateLabel;

        public GalleryCell(string cellId) : base(UITableViewCellStyle.Default, cellId)
        {
            SelectionStyle = UITableViewCellSelectionStyle.Gray;

            _imageView = new UIImageView()
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            _titleLabel = new UILabel()
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            _dateLabel = new UILabel()
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            ContentView.Add(_imageView);
            ContentView.Add(_titleLabel);
            ContentView.Add(_dateLabel);

        }

        public void UpdateCell(GalleryItem gallery)
        {
            _imageView.Image = UIImage.LoadFromData(NSData.FromArray(gallery.ImageData));
            _titleLabel.Text = gallery.Title;
            _dateLabel.Text = gallery.Date;

        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            ContentView.TranslatesAutoresizingMaskIntoConstraints = false;


        }
    }
}
