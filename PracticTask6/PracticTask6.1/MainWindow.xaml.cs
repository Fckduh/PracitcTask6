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

namespace PracticTask6._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBinding commandBinding = new CommandBinding();
            commandBinding.Command = SystemCommands.CloseWindowCommand;
            commandBinding.Executed += exit;
            //MenuItem.CommandBindings.Add(commandBinding);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        void fileExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Close this window
            this.Close();
        }
    }
}
