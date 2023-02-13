namespace SimplyKnowHau_Web_API.Entities
{
    public class Animal
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string ImageURL { get; set; }

        public int CategoryId { get; set; }
    }
}
