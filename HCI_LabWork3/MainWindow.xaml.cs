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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CheckItem_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ExitItem_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AboutItem_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.M && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                MenuItem_Click(this, e);
            if (e.Key == Key.E && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                ExitItem_Click(this, e);
            if (e.Key == Key.C && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                CheckItem_Click(this, e);
            if (e.Key == Key.A && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                AboutItem_Click(this, e);
            MenuItem item;
            if (e.Key == Key.C)
            {
                FileDialog.IsSubmenuOpen = true;

            }
            if (e.Key == Key.A && FileDialog.Items.Contains("New"))
            {
                FileDialog.Items.Add(new Separator());
                FileDialog.Items.Add("New");
                FileDialog.Items.Add("Open");
                FileDialog.Items.Add("Close");
                item = (MenuItem)FileDialog.Items[3];
                FileDialog.Items.Remove("Message");
                FileDialog.Items.Add(new Separator());
                FileDialog.Items.Add(item);

            }

        }
    }
}
