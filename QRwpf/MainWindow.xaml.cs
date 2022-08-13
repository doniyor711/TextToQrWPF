using QRwpf.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QRwpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ScanQRBtn_Click(object sender, RoutedEventArgs e)
        {
            QRCodeGeneratorService codeGeneratorService = new();
            QRCodeImg.Source =  new BitmapImage( new Uri(codeGeneratorService.GenerateQr(QRText.Text)));
            //QRCodeImg.Margin = new Thickness(270, 0, 0, 300);


        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
