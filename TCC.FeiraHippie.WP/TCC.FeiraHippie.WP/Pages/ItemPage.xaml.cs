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
    public partial class ItemPage : PhoneApplicationPage
    {
        #region iVars
        private ItemCategory _category;
        private Item _originalItem;
        private Item _currentItem;

        #endregion

        #region CTOR
        public ItemPage()
        {
            InitializeComponent();
            //
            _originalItem = _currentItem = null;
        } 
        #endregion

        #region Navigation Handlers
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            int categoryId = int.Parse(NavigationContext.QueryString["CategoryID"]);
            _category = Model.Instance.GetCategory(categoryId);

            int itemId = int.Parse(NavigationContext.QueryString["ItemID"]);
            if(itemId != -1)
            {
                _originalItem = _currentItem = _category.GetItem(itemId);
            }

            SetupPage();
        }        
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);
            e.Cancel = !ConfirmGoBack();
        }
        #endregion

        #region Button Handlers
        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            var item = new Item()
            {
                Id = 12,
                Title = txtTitle.Text
            };
            _category.Items.Add(item);
            NavigationService.GoBack();

        }
        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            if (ConfirmGoBack())
                NavigationService.GoBack();
        }        
        #endregion

        private void SetupPage()
        {
            if (_currentItem == null)
            {
                lblPageTitle.Text = "Novo Item";

            }
            else
            {
                lblPageTitle.Text = "Editar Item";
            }
        }
        private bool ConfirmGoBack()
        {
            if (_originalItem != _currentItem)
            {
                var restult = MessageBox.Show("Vc mudou as info do negocio, se nao savar vai perder cusao", "Tem certeza????", MessageBoxButton.OKCancel);
                return restult == MessageBoxResult.OK;
            }
            else
            {
                return true;
            }
        }
        
    }
}