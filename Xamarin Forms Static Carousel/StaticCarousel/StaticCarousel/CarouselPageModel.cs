using System;
namespace StaticCarousel
{
	public class CarouselPageModel
	{

		public int pageNumber { get; set; }
		public string description { get; set; }

        public CarouselPageModel()
		{

		}

        public CarouselPageModel(int pageNumber, string description)
		{
			this.pageNumber = pageNumber;
			this.description = description;
		}

	}
}

