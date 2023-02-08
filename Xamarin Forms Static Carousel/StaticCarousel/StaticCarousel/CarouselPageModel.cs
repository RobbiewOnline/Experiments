using System;
namespace StaticCarousel
{
	public class CarouselPageModel
	{

		public int PageNumber { get; set; }
		public string Description { get; set; }

        public CarouselPageModel()
		{

		}

        public CarouselPageModel(int pageNumber, string description)
		{
			this.PageNumber = pageNumber;
			this.Description = description;
		}

	}
}

