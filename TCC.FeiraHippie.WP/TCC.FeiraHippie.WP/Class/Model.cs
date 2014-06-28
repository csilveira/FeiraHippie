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
    public class Model
    {
        private static Model _instance = null;

        public static Model Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Model();

                return _instance;
            }
        }

        private Model()
        {
        }

        public ItemCategory GetCategory(int id)
        {
            var a = new ItemCategory();
            a.Id = 12345;

            a.Title = "CAIOOO";
            a.Items.Add(new Item()
            {
                Id = 1,
                Title = "Bolse"
            });
            a.Items.Add(new Item()
            {
                Id = 2,
                Title = "Bolse2"
            });
            a.Items.Add(new Item()
            {
                Id = 3,
                Title = "Bolse3"
            });
            return a;
        }
    }
}
