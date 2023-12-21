namespace WebSiteSouzMash.DAL.Postgres.Entities
{
	public class NewsEntity
	{
		public Guid Id { get; set; }

		public string Title { get; set; } = string.Empty;

		public string TextData { get; set; } = string.Empty;

		public ImageEntity? MainImage { get; set; }

		public Guid? MainImageId { get; set; }
	}
}
