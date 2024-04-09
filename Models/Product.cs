using System.ComponentModel.DataAnnotations;

namespace RestoCommand.Models
{
    public enum ProductType
    {
        Onigiri,
        Side,
        Dessert,
        Bento,
        Drink,
        Special
    }

    public enum ProductParticularity
    {
        None,
        Vegan,
        Vegetarian,
        GlutenFree,
        LactoseFree,
        NutFree,
        Spicy
    }

    public class Product
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Name must be at most 100 characters long")]
        public string Name { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public ProductType Type { get; set; }
        public List<ProductParticularity> ProductParticularities { get; set; } = new List<ProductParticularity>();

        public string ImageUrl { get; set; } // Call to api to get image

        public void Copy(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            Price = product.Price;
            Type = product.Type;
            ProductParticularities = product.ProductParticularities;
            ImageUrl = product.ImageUrl;
        }

    }

}
