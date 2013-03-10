using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        int currentPaletteIndexR;
        int currentPaletteIndexG;
        int currentPaletteIndexB;


        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            currentPaletteIndexR = (int)e.NewValue;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255,(byte)currentPaletteIndexR, (byte)currentPaletteIndexG, (byte)currentPaletteIndexB);
            n1.Fill = mySolidColorBrush;
           // label4.Content = e.NewValue.ToString();
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            currentPaletteIndexG = (int)e.NewValue;

            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, (byte)currentPaletteIndexR, (byte)currentPaletteIndexG, (byte)currentPaletteIndexB);
            n1.Fill = mySolidColorBrush;
           // label5.Content = Convert.ToString(currentPaletteIndexG);
        }

        private void slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            currentPaletteIndexB = (int)e.NewValue;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, (byte)currentPaletteIndexR, (byte)currentPaletteIndexG, (byte)currentPaletteIndexB);
            n1.Fill = mySolidColorBrush;
           // label5.Content = Convert.ToString(currentPaletteIndexB);
        }


    }
}
