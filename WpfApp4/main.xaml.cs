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
    /// Логика взаимодействия для main.xaml
    /// </summary>
    public partial class main : Page
    {
        GameSet InfGame;
        int countTables = 0;

        public main()
        {
            InitializeComponent();
            Update_file();
            //int count = InfGame.Tables.Count;
            //MessageBox.Show(Convert.ToString(count));
        }

        public void Update_file()
        {
            InfGame = new GameSet();
            InfGame.ReadXml("Data.xml");
            countTables = InfGame.Tables[0].Rows.Count; //Кол-в добавленных игр
            Console.WriteLine(countTables);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= countTables; i++)
            {
                if (Convert.ToString(InfGame.Tables[0].Rows[countTables - 1].ItemArray[1]) != "Hitman 2")
                {
                    InfGame.Tables[0].Rows.Add(new object[] { "Hitman", "Hitman 2" });
                    InfGame.WriteXml("Data.xml");
                    Console.WriteLine(Convert.ToString(InfGame.Tables[0].Rows[countTables].ItemArray[1]));
                    Console.WriteLine(InfGame.Tables[0]);
                    Update_file();
                    Console.WriteLine(countTables);
                    MessageBox.Show("Игры добавлена");
                    break;
                }
                else if (Convert.ToString(InfGame.Tables[0].Rows[countTables - 1].ItemArray[1]) == "Hitman 2")
                {
                    MessageBox.Show("Вы уже добавили эту игру");
                    break;
                }
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= countTables; i++)
            {
                if (Convert.ToString(InfGame.Tables[0].Rows[countTables - 1].ItemArray[1]) != "Counter-Strike: Global Offensive")
                {
                    InfGame.Tables[0].Rows.Add(new object[] { "Cs Go", "Counter-Strike: Global Offensive" });
                    InfGame.WriteXml("Data.xml");
                    Console.WriteLine(Convert.ToString(InfGame.Tables[0].Rows[countTables].ItemArray[1]));
                    Console.WriteLine(InfGame.Tables[0]);
                    Update_file();
                    Console.WriteLine(countTables);
                    MessageBox.Show("Игры добавлена");
                    break;
                }
                else if (Convert.ToString(InfGame.Tables[0].Rows[countTables - 1].ItemArray[1]) == "Counter-Strike: Global Offensive")
                {
                    MessageBox.Show("Вы уже добавили эту игру");
                    break;
                }
            }
        }
    }
}
