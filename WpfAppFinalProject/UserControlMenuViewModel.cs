using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAppFinalProject
{
    public class UserControlMenuViewModel : BaseViewModel
    {
        ObservableCollection<Product> ViewProduct { get; set; }
        public UserControlMenuViewModel()
        {
            FillProduct();
        }

        private void FillProduct()
        {

            ViewProduct = new ObservableCollection<Product>() {
            new Product(){
                            ProductId=1,ModelName="Narzo 60 pro" ,BrandName="RealMe",
                            price=2999.95,ViewDetailCommand= new RelayCommand(ViewdetailCommandClick),
                            ProductImageUrl="/RealmeNarzo60.jpg",BtnContent="View Details",
                            SpecList= new List<Specification>(){ new Specification(){SpecName="Ram",SpecValue="8 GB"} }
} };
            ProductList = ViewProduct;
            OnPropertyChanged(nameof(ProductList));
        }

        public void ViewdetailCommandClick(object obj)
        {
            ObservableCollection<Product> ProductListTemp= ProductList;
            // ProductList.Clear();
            //ProductList.Remove((Product)obj); 
            for (int i = 0; i < ViewProduct.Count; i++)
            {
                ProductList[i].ProductId = ProductListTemp[i].ProductId;
                ProductList[i].ModelName = ProductListTemp[i].ModelName;
                ProductList[i].BrandName = ProductListTemp[i].BrandName;
                ProductList[i].ProductImageUrl = ProductListTemp[i].ProductImageUrl;
                ProductList[i].SpecList = ProductListTemp[i].SpecList;
                

                if (ProductListTemp[i].ProductId == (int)obj)
                {
                    if (ProductListTemp[i].BtnContent == "View Details")
                    {
                        ProductList[i].BtnContent = "Back";


                    }
                    else
                        { }
                }
            OnPropertyChanged(nameof(ProductList));

            }
        }
    }
    public class Product
    {
        public int ProductId { get; set; }
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public string ProductImageUrl { get; set; }
        public Double price { get; set; }
        public string BtnContent { get; set; }
        public ICommand ViewDetailCommand { get; set; }
        public List<Specification> SpecList { get; set; }
    }
    public class Specification
    {

        public string SpecName { get; set; }
        public string SpecValue { get; set; }

    }

}
