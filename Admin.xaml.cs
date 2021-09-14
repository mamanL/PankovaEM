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

namespace ПанковаЕМ
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        List<Книги> Book = Class.Book.Книги.ToList();
        public Admin()
        {
            InitializeComponent();
            DGServises.ItemsSource = Book;
        }

        int i = -1;

        private void TextBlock_Initialized(object sender, EventArgs e)
        {
            if (i < Book.Count)
            {
                i++;
                TextBlock TB = (TextBlock)sender;
                Книги S = Book[i];
                TB.Text = S.Название;
                //i++;
            }
        }

        private void TextBlock_Initialized_Cost(object sender, EventArgs e)
        {


            if (i < Book.Count)
            {
                TextBlock Price = (TextBlock)sender;
                Книги S = Book[i];
                Price.Text = Convert.ToInt32(S.Цена) + "";
            }
        }

        private void Button_Initialized_Red(object sender, EventArgs e)
        {
            Button BtnRed = (Button)sender;
            if (BtnRed != null)
            {
                BtnRed.Uid = Convert.ToString(i);
            }

        }
    }
}
