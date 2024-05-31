using System.ComponentModel.DataAnnotations;

namespace ASP_Homework_Product.Models
{
    public class Product
    {
        private static int instanceCounter = 0;
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        
        public string ImagePath { get; set; }

        public Product() 
        {
            Id = instanceCounter;
            instanceCounter += 1;
        }

        public Product(string name, string cost, string description, string imagePath)
        {
            Id = instanceCounter;
            Title = name;
            Author = cost;
            Description = description;
            instanceCounter += 1;
            ImagePath = imagePath;
        }

        public override string ToString()
        {
            return $"{Id}\n{Title}\n{Author}";
        }
    }
}
