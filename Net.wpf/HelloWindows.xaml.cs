using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Net.wpf;

public partial class HelloWindow : Window
{
    public HelloWindow(string message)
    {
        InitializeComponent();
        MessageTextBlock.Text = message;
    }
}
