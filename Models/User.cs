namespace Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsRegisted { get; set; } = false;
        public bool IsAdmin { get; set; } = false;
        public List<int> Favourites { get; set; }
        public List<int> Recipes { get; set; }
    }
}
