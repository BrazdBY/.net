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

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (HelloTextBox.Text == "Enter the name")
        {
            HelloButton.Focus();

        }
    }


    private void HelloButton_Click(object sender, RoutedEventArgs e)
    {
        string username = HelloTextBox.Text;
        var HelloMessage = SharedLibrary.SayHello.GetHello(username);
        var HelloWindow = new HelloWindow(HelloMessage);
        HelloWindow.Show();
    }


    private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
    {

    }


    private void HelloTextBox_GotFocus(object sender, RoutedEventArgs e)
    {
        if (HelloTextBox.Text == "Enter the name")
        {
            HelloTextBox.Text = "";
        }
    }
}
