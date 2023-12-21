namespace WebSiteSouzMash.DAL.Postgres.Entities
{
	public class ImageEntity
	{
		public Guid Id { get; set; }

		public string ImagePath { get; set; } = string.Empty;

		public NewsEntity? News { get; set; }

		public Guid? NewsId { get; set; }
	}
}
