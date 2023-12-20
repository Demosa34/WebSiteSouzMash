namespace WebSiteSouzMash.BL
{
    public class SectionService
    {
        public async Task CreateSection(MainSection section)
        {
            // обращение к бд
            _sectionRepository.Create(section);

            _userRepository.Update();

            // кэширование
        } 
    }
}