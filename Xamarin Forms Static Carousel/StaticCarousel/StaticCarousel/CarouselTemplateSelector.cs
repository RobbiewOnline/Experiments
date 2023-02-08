
using System;
using Xamarin.Forms;

namespace StaticCarousel
{
    public class CarouselTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Page1Template { get; set; }
        public DataTemplate Page2Template { get; set; }
        public DataTemplate Page3Template { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            int pageNumber = ((CarouselPageModel)item).PageNumber;

            if (pageNumber == 1)
            {
                return Page1Template;
            }
            else if (pageNumber == 2)
            {
                return Page2Template;
            }
            else if (pageNumber == 3)
            {
                return Page3Template;
            }

            // Shouldn't fall through here
            return Page1Template;
        }
    }
}
