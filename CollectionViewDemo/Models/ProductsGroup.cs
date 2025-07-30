namespace CollectionViewDemo.Models;

public partial class ProductsGroup(string name, List<Product> products) : List<Product>(products)
{
    public string Name { get; set; } = name;
}
