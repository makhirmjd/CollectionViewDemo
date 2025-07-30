namespace CollectionViewDemo.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public string? Image { get; set; }
    public int Stock { get; set; }
    public bool HasOffer { get; set; }
    public decimal OfferPrice { get; set; }
}
