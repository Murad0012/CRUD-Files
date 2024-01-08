namespace P335_BackEnd.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
