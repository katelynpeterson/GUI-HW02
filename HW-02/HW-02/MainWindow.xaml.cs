using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace HW_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int listCount = 0;
        int click = 0;
        int click2 = 0;
        List<String> pictureArray = new List<String>();
        Uri resourceUri = new Uri("Images/mountain_lake.jpeg", UriKind.Relative);

        public MainWindow()
        {
            InitializeComponent();
            
            pictureArray.Add("/Images/lilies.jpeg");
            pictureArray.Add("/Images/swans_on_lake.jpeg");
            pictureArray.Add("/Images/tree_by_water.jpeg");
            pictureArray.Add("/Images/wave.jpeg");
            pictureArray.Add("/Images/tree_lined_lane.jpeg");
            pictureArray.Add("/Images/tree_in_field.jpeg");

            userName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;

            picture.Background = brush;
        }

        private void btnClick_getNewPicture(object sender, RoutedEventArgs e)
        {
            if (listCount < pictureArray.Count)
            {
                resourceUri = new Uri(pictureArray[listCount], UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;

                picture.Background = brush;
                listCount += 1;
            }
            else
            listCount = 0;
        }

        private void btnClick_changeColor(object sender, RoutedEventArgs e)
        {
            myApp.Background = (Brush)System.ComponentModel.TypeDescriptor.GetConverter(typeof(Brush)).ConvertFromInvariantString("Blue");
            click += 1;
            if(click % 2 == 0)
                myApp.Background = (Brush)System.ComponentModel.TypeDescriptor.GetConverter(typeof(Brush)).ConvertFromInvariantString("white");
        }

        private void btnClick_changeFont(object sender, RoutedEventArgs e)
        {
            title.Background = (Brush)System.ComponentModel.TypeDescriptor.GetConverter(typeof(Brush)).ConvertFromInvariantString("Orange");
            welcome.Text = "Howdy";
            click2 += 1;
            if (click2 % 2 == 0)
            {
                title.Background = (Brush)System.ComponentModel.TypeDescriptor.GetConverter(typeof(Brush)).ConvertFromInvariantString("Purple");
                welcome.Text = "Welcome";
            }
        }
    }
}
