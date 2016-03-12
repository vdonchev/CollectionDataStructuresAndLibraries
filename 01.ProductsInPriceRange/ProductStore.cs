namespace _01.ProductsInPriceRange
{
    using System;
    using Wintellect.PowerCollections;

    public class ProductStore
    {
        private readonly OrderedMultiDictionary<decimal, string> products;

        public ProductStore()
        {
            this.products = new OrderedMultiDictionary<decimal, string>(true);
        }

        public void Add(string productName, decimal productPrice)
        {
            this.products.Add(productPrice, productName);
        }

        public void EachProductInRange(decimal start, decimal end, Action<string> action)
        {
            var productsInRangeQuery = this.products.Range(start, true, end, true);
            foreach (var priceRange in productsInRangeQuery)
            {
                foreach (var item in priceRange.Value)
                {
                    action($"{item} {priceRange.Key}");
                }
            }
        }
    }
}