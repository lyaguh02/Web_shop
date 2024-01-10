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
    /// Логика взаимодействия для List.xaml
    /// </summary>
    public partial class List : Page
    {
        GameSet InfGame;
        int countTables = 0;

        public List()
        {
            InitializeComponent();
            Update_file();
            if (countTables > 1)
            {
/*                for (int i = 2; i <= countTables; i++)
                { }*/
                GameName1.Content = Convert.ToString(InfGame.Tables[0].Rows[countTables - 1].ItemArray[1]);
                GameImag.Source = new BitmapImage(new Uri($"/Images/{Convert.ToString(InfGame.Tables[0].Rows[countTables - 1].ItemArray[0])}.png", UriKind.Relative));
            }
        }

        public void Update_file()
        {
            InfGame = new GameSet();
            InfGame.ReadXml("Data.xml");
            countTables = InfGame.Tables[0].Rows.Count; //Кол-в добавленных игр
        }

    }
}
