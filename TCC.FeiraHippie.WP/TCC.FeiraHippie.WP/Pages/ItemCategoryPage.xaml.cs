using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace TCC.FeiraHippie.WP
{
    public partial class ItemCategoryPage : PhoneApplicationPage
    {
        #region iVars
        ItemCategory _category;
        #endregion

        #region CTOR
        public ItemCategoryPage()
        {
            InitializeComponent();
        } 
        #endregion

        #region Navigation Handlers
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            int id = int.Parse(NavigationContext.QueryString["ID"]);
            _category = Model.Instance.GetCategory(id);
            
            SetupPage();
        }

        private void SetupPage()
        {
            lblPageTitle.Text = _category.Title;
            lboxItems.ItemsSource = _category.Items;
        }
        #endregion

        #region Button Handlers
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NavigateToItemPage(_category.Id, -1);
        }

        private void lboxItems_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            int index = lboxItems.SelectedIndex;
            var item = _category.Items[index];

            NavigateToItemPage(_category.Id, item.Id);
        }

        private void NavigateToItemPage(int categoryId, int itemId)
        {
            var uriStr = String.Format("/Pages/ItemPage.xaml?CategoryID={0}&ItemID={1}", categoryId, itemId);

            NavigationService.Navigate(new Uri(uriStr, UriKind.RelativeOrAbsolute));
        }
        #endregion
    }
}