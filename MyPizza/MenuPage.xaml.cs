using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MyPizza
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    ///

    public partial class MenuPage : Page
    {
        private double price = 0;
        private double finalPrice = 0;
        private string[] pizzas =
{
            "Маргарита",
            "Четыре сыра",
            "Песто",
            "Пепперони",
            "Гавайская"
        };
        public MenuPage()
        {
            InitializeComponent();
            for (int i=0;i<pizzas.Length;i++) {
                PizzaListBox.Items.Add(pizzas[i]);
            }
            CountPriceLabel.Content = $"Итоговая стоимость: {price}";
        }

        private void AddToBucketButtonClick(object sender, RoutedEventArgs e)
        {
            finalPrice += price;
            CountPriceLabel.Content = $"Итоговая стоимость: {finalPrice}";

        }
        private void PizzaListSeletionChanged(object sender, SelectionChangedEventArgs e) {
            switch (PizzaListBox.SelectedIndex) {
                case 0: PriceLabel.Content = "Цена: 300 рублей";
                    price = 300;
                    break;
                case 1:
                    PriceLabel.Content = "Цена: 400 рублей";
                    break;
                case 2:
                    PriceLabel.Content = "Цена: 500 рублей";
                    price = 500;
                    break;
                case 3:
                    PriceLabel.Content = "Цена: 650 рублей";
                    price = 650;
                    break;
                case 4:
                    PriceLabel.Content = "Цена: 450 рублей";
                    price = 450;
                    break;
                default:PriceLabel.Content = "Выберите пиццу.";
                    break;
            }
        }
    }
}
