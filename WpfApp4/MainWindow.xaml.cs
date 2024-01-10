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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public static string[] Array { get; set; }

        GameSet InfGame;

        public void Data(string data)
        {
            string[] List = { data };
            List[List.Length + 1] = "Hello";
            Console.WriteLine(List[2]);
        }

        public MainWindow()
        {
            InitializeComponent();

            frime.Navigate(new home());
            InfGame = new GameSet();
            InfGame.Tables.Add("Games");
            InfGame.Tables[0].Columns.Add("Image");
            InfGame.Tables[0].Columns.Add("Name");
            InfGame.Tables[0].Rows.Add(new object[] { "Hello","Goodbye" });


            InfGame.WriteXml("Data.xml");
            //MessageBox.Show("Файл сохранён");
            //InfGame.Tables[0].DefaultView;
            Console.WriteLine(InfGame.Tables[0].Columns[0]);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            frime.Navigate(new main());
        }

        private void gamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            //frime.Navigate(new categorii());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frime.Navigate(new List());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
