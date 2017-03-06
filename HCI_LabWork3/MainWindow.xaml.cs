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

namespace HCI_LabWork3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void MessageItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is default message!");
        }

        private void CheckItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageItem.IsEnabled == true)
            {
                MessageItem.IsEnabled = false;
                MessageItemContext.IsEnabled = false;
                MessageTool.IsEnabled = false;
            }
            else
            {
                MessageItem.IsEnabled = true;
                MessageItemContext.IsEnabled = true;
                MessageTool.IsEnabled = true;
            }

        }

        private void ExitItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void AboutItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi. This is laboratory work on the subject HCI,\n by student Hordiienko, ICIT-218a-SE",
                "About");
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.M && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                MessageItem_Click(this, e);
            if (e.Key == Key.E && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                ExitItem_Click(this, e);
            if (e.Key == Key.C && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                CheckItem_Click(this, e);
            if (e.Key == Key.A && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                AboutItem_Click(this, e);
            if (e.Key == Key.C)
            {
                FileDialog.IsSubmenuOpen = true;

            }
            if (e.Key == Key.A && !FileDialog.Items.Contains("New"))
            {
                FileDialog.Items.Add(new Separator());
                FileDialog.Items.Add("New");
                FileDialog.Items.Add("Open");
                FileDialog.Items.Add("Close");
                FileDialog.Items.RemoveAt(0);
                FileDialog.Items.Add(new Separator());

            }

        }
    }
}
