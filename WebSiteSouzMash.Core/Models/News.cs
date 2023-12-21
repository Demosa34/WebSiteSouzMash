namespace WebSiteSouzMash.Core.Models
{
    public class News
    {
        public const int MAX_TITLE_LENGTH = 80;

        public News(string title, string textData, Image? mainImage)
        {
            Id = Guid.NewGuid();
            Title = title;
            TextData = textData;
            MainImage = mainImage;
        }

        public Guid Id { get; }

        public string Title { get; } = string.Empty;

        public string TextData { get; } = string.Empty;

        public Image? MainImage { get; }

        public static (News? News, string? Error) Create(string title, string textData, Image? mainImage)
        {
            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
            {
                return (null, "Title can not be empty");
            }

            // доделать валидацию

            return (new News(title, textData, mainImage), null);
        }
    }

	public class Image
	{
		public string ImagePath { get; } = string.Empty;
	}
}
