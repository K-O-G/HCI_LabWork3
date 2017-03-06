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
    /// 1. Create an interface as shown in Fig .3 
    /// “File” menu item has three commands Message, Check, Exit. 
    /// “Help” item includes a command “About”. 
    /// Selection of “Message” will open a message window. 
    /// Clicking “Exit” will close the application. 
    /// Selection of “Check” clears the check box and makes the command “Message” unavailable. T
    /// he second choice of “Check” will return the action. 
    /// Selection “About” will display information about your application.
    /// 2. Create necessary menu items with a command list and shortcuts.
    /// 3. Create a Toolbar, which duplicates “File” menu items.
    /// 4. For several basic functions create icons using one of famous photo editors, for example, 
    /// MS Paint.When creating icons, use affordance and analogies well known for most potential users.
    /// 5. Create the context menu that duplicates the File menu.
    /// 6. Define an opportunity to close the application when you press X.
    /// 7. Complete the application according to the variant (Table 5)
    /// 14.Set so, when we press C button the message with quantity of commands of “File” menu item 
    /// will be shown.When we press A button commands “New”, “Open” and “Close” will be added to “File” 
    /// menu item and the command “Message” will be deleted.
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
