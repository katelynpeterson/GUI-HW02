using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HW_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int listCount = 0;

        public MainWindow()
        {
            InitializeComponent();

            userName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;           
        }

        public Image GetNextImage(int next)
        {            
            List<Image> imgArray = new List<Image>();
            //imgArray.Add(Image.FromFile("c/Users/katel/source/repos/GUI-HW02/pics/"));
            return imgArray[next];
        }

        private void btnClick_getNewPicture(object sender, RoutedEventArgs e)
        {

            listCount += 1;
            GetNextImage(listCount);
        }
    }
}
