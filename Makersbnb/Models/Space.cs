namespace Makersbnb.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Space
    {
        [Key]
        public int Id {get; set;}

        public string? Name {get; set;}
        public string? Description {get; set;}
        public int? Price {get; set;}
        public int? Bedrooms {get; set;}

        public Space(string name, string description, int price, int bedrooms)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Bedrooms = bedrooms;
        }
    
        public Space() {}
    }
}