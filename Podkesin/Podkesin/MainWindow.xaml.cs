using Panuon.UI.Silver;
using System.Collections.Generic;

namespace Podkesin
{
    public partial class MainWindow : WindowX
    {
        public MainWindow()
        {
            InitializeComponent();

            var itemsSource = new List<object>()
            {
                new { Row = "01", Icon = "/Podkesin;component/Resources/Images/Image1.png", DisplayName = "Maintain Productivity #01", Author = "Asal Design", Category = "Productivity", TimeSpan = "20:11" },
                new { Row = "02", Icon = "/Podkesin;component/Resources/Images/Image2.png", DisplayName = "Make the kitchen comfortable #02", Author = "Bunda Nani", Category = "Productivity", TimeSpan = "15:12" },
                new { Row = "03", Icon = "/Podkesin;component/Resources/Images/Image3.png", DisplayName = "What Bitcoin, ETH, Etc?", Author = "Leek", Category = "Money", TimeSpan = "8:12" },

            };
            IcViewer.ItemsSource = itemsSource;
            LsvViewer.ItemsSource = itemsSource;

        }
    }
}
