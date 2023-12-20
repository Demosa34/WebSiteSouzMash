namespace WebSiteSouzMash.Core.Models
{
    public class MainSection
    {
        public const int MAX_TITLE = 250;

        private MainSection(string title, string description, int position)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            IsVisible = true;
            Position = position;
        }

        public Guid Id { get; }
        
        public string Title { get; } = string.Empty;

        public string Description { get; } = string.Empty;

        public bool IsVisible { get; }

        public int Position { get; } = 0;

        public static (MainSection, string) Create(string title, string description, int position)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE)
            {
                error = "Заголовок не может быть пустым";
            }

            if (string.IsNullOrEmpty(description))
            {
                error = "Описание не может быть пустым";
            }

            if (position < 0)
            {
                error = "Позиция не может быть отрицательной";
            }

            var section = new MainSection(title, description, position);

            return (section, error);
        }
    }
}
