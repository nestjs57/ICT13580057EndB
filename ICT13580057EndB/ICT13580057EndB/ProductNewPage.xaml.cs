using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ICT13580057EndB.Models;
namespace ICT13580057EndB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductNewPage : ContentPage
    {
        Product product;
        public ProductNewPage(Product product = null)
        {
            InitializeComponent();
            typePicker.Items.Add("กระบะ");
            typePicker.Items.Add("เก๋ง");
            typePicker.Items.Add("สิบล้อ");

            brandPicker.Items.Add("โตโยต้า");
            brandPicker.Items.Add("วีออส");

            colorPicker.Items.Add("ขาว");
            colorPicker.Items.Add("เทา");

            contryPicker.Items.Add("กรุงเทพ");
            contryPicker.Items.Add("เชียงใหม่");

            YearStepper.ValueChanged += YearStepper_ValueChanged;
            mileSlider.ValueChanged += MileSlider_ValueChanged;

            EnterButton.Clicked += EnterButton_Clicked;
            if (product != null)
            {
                typePicker.SelectedItem = product.Type;
                brandPicker.SelectedItem = product.brand;
                roonEntry.Text = product.roon;
                yearLabel.Text = product.year;
                mileLabel.Text = product.numMile;
                colorPicker.SelectedItem = product.color;
                descriptionEntry.Text = product.Description;
                priceEntry.Text = product.Productprice;
                contryPicker.SelectedItem = product.contry;
                phoneEntry.Text = product.phone;
            }

        }

        async private void EnterButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "ต้องการบันทึกไหม", "ใช่", "ไม่ใช่");
            if (isOk)
            {
                if (product == null)
                {
                    product = new Product();

                    
                    product.Type = typePicker.SelectedItem.ToString();
                    product.brand = brandPicker.SelectedItem.ToString();
                    product.roon = roonEntry.Text;
                    product.year = yearLabel.Text;
                    product.numMile = mileLabel.Text;
                    product.color = colorPicker.SelectedItem.ToString();
                    product.deler = deler.IsToggled;
                    product.Description = descriptionEntry.Text;
                    product.Productprice = priceEntry.Text;
                    product.contry = contryPicker.SelectedItem.ToString();
                    product.phone = phoneEntry.Text;
                    var id = App.DbHelper.AddProduct(product);
                    await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ #" + id, "ตกลง");

                }
                else
                {
                    product = new Product();

                    
                    product.Type = typePicker.SelectedItem.ToString();
                    product.brand = brandPicker.SelectedItem.ToString();
                    product.roon = roonEntry.Text;
                    product.year = yearLabel.Text;
                    product.numMile = mileLabel.Text;
                    product.color = colorPicker.SelectedItem.ToString();
                    product.deler = deler.IsToggled;
                    product.Description = descriptionEntry.Text;
                    product.Productprice = priceEntry.Text;
                    product.contry = contryPicker.SelectedItem.ToString();
                    product.phone = phoneEntry.Text;
                    var id = App.DbHelper.UpdateProduct(product);
                    await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ #" + id, "ตกลง");
                }
                await Navigation.PopModalAsync();
            }
        }

        private void MileSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            mileLabel.Text = value.ToString();
        }

        private void YearStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            yearLabel.Text = value.ToString();
        }
    }
}