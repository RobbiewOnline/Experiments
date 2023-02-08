using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StaticCarousel
{
    public partial class MainPage : ContentPage
    {

        public List<CarouselPageModel> Pages { get; set; } = new List<CarouselPageModel>();
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public MainPage()
        {

            Pages.Add(new CarouselPageModel { PageNumber = 1, Description = "Step 1 - Edit MainPage.xaml.cs to add a new CarouselPageModel" });
            Pages.Add(new CarouselPageModel { PageNumber = 2, Description = "Page 2 - Edit the CarouselTemplateSelector.cs to map the index to the page" });
            Pages.Add(new CarouselPageModel { PageNumber = 3, Description = "Page 3 - Edit the MainPage.xaml" });

            BindingContext = this;

            InitializeComponent();

        }
    }
}

