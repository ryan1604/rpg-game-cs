﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GroupedInventoryItem : INotifyPropertyChanged
    {
        private GameItem _item;
        private int _quantity;

        public event PropertyChangedEventHandler PropertyChanged;

        public GameItem Item 
        { 
            get { return _item; } 
            set 
            {
                _item = value;
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
            }
        }

        public GroupedInventoryItem(GameItem item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
    }
}
