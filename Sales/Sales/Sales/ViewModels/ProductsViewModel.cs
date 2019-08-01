namespace Sales.ViewModels
{
    using Sales.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using Services;

    public class ProductsViewModel : BaseViewModel
    {
        private ApiServices apiServices;
        public ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }
    }
}
