using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SolidWallpapers
{
    public partial class MainPage : ContentPage
    {
        public readonly BindableProperty IsPickerVisibleProperty = BindableProperty.Create(nameof(IsPickerVisible), typeof(bool), typeof(bool), true, BindingMode.TwoWay);

        public bool IsPickerVisible
        {
            get => (bool)GetValue(IsPickerVisibleProperty);
            set => SetValue(IsPickerVisibleProperty, value);
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Screen_Tapped(object sender, EventArgs e)
        {
            IsPickerVisible = !IsPickerVisible;
        }
    }
}
