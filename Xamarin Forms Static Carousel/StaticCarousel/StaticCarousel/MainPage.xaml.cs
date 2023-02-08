using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StaticCarousel
{
    public partial class MainPage : ContentPage
    {

        public List<CarouselPageModel> Pages { get; set; } = new List<CarouselPageModel>();

        public MainPage()
        {

            Pages.Add(new CarouselPageModel { pageNumber = 1, description = "Page 1" });
            Pages.Add(new CarouselPageModel { pageNumber = 2, description = "Page 2" });
            Pages.Add(new CarouselPageModel { pageNumber = 3, description = "Page 3" });

            BindingContext = this;

            InitializeComponent();

        }
    }
}

