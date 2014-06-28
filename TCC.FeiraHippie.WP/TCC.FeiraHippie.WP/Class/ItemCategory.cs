using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace TCC.FeiraHippie.WP
{
    public class ItemCategory
    {
        #region Properties
        public String Title { get; set; }
        public List<Item> Items { get; set; }
        public int Id { get;  set; }
        #endregion

        #region CTOR
        public ItemCategory()
        {
            Items = new List<Item>();
        } 
        #endregion

        #region Public Methods
        public Item GetItem(int id)
        {
            foreach (var item in Items)
            {
                if (item.Id == id)
                    return item;
            }

            return null;
        }
        #endregion
    }
}
