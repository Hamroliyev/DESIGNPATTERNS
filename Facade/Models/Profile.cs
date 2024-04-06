namespace Facade.Models
{
    public class Profile
    {
        public string Username { get; set; }
        public ColorTheme ColorTheme { get; set; }

        public override string ToString()
        {
            return $"{Username}: Color Theme {ColorTheme}";
        }
    }
}
