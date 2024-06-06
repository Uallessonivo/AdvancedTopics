namespace AdvancedTopics.Generics
{
    public class Product
    {
        public string Title { get; set; } = default!;
        public float Price { get; set; } = default!;
    }

    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}
