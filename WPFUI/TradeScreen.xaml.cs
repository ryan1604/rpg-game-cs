using SOSCSRPG.ViewModels;
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
using System.Windows.Shapes;
using SOSCSRPG.Models;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for TradeScreen.xaml
    /// </summary>
    public partial class TradeScreen : Window
    {
        public GameSession Session => DataContext as GameSession;
        public TradeScreen()
        {
            InitializeComponent();
        }

        private void OnClick_Sell(object sender, RoutedEventArgs e)
        {
            GroupedInventoryItem groupedInventoryItem = 
                ((FrameworkElement)sender).DataContext as GroupedInventoryItem;
            if (groupedInventoryItem != null)
            {
                Session.CurrentPlayer.ReceiveGold(groupedInventoryItem.Item.Price);
                Session.CurrentPlayer.RemoveItemFromInventory(groupedInventoryItem.Item);
                Session.CurrentTrader.AddItemToInventory(groupedInventoryItem.Item);
            }
        }

        private void OnClick_Buy(object sender, RoutedEventArgs e)
        {
            GroupedInventoryItem groupedInventoryItem = ((FrameworkElement)sender).DataContext as GroupedInventoryItem;
            if (groupedInventoryItem != null)
            {
                if (Session.CurrentPlayer.Gold > groupedInventoryItem.Item.Price)
                {
                    Session.CurrentPlayer.SpendGold(groupedInventoryItem.Item.Price);
                    Session.CurrentPlayer.AddItemToInventory(groupedInventoryItem.Item);
                    Session.CurrentTrader.RemoveItemFromInventory(groupedInventoryItem.Item);
                }
                else
                {
                    MessageBox.Show("You do not have enough gold.");
                }
            }
        }

        private void OnClick_Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
