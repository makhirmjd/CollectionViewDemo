using CollectionViewDemo.Models;

namespace CollectionViewDemo.Selectors;

public class ProductDataTemplateSelector : DataTemplateSelector
{
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        if (item is Product product)
        {
            if (!product.HasOffer)
            {
                Application.Current!.Resources.TryGetValue("ProductStyle", out object? productStyle);
                return productStyle as DataTemplate ?? new();
            }
        }

        return new ();
    }
}
