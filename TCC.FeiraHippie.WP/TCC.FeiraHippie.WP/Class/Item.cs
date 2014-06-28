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

namespace TCC.FeiraHippie.WP
{
    public class Item
    {
        public override string ToString()
        {
            return Title;
        }
        #region Properties
        public string Title {get; set;}
        public string Description { get; set; }
        public string Quantity { get; set; }
        public int Id { get;  set; }
        #endregion
    }
}
