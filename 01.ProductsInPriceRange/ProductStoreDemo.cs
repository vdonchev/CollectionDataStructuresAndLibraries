namespace _01.ProductsInPriceRange
{
    using System;

    public static class ProductStoreDemo
    {
        public static void Main()
        {
            // NOTE: OrderedMultiDictionary<decimal, string> used :)
            var store = new ProductStore();

            store.Add("apples", 2.50M);
            store.Add("bananas", 1.20M);
            store.Add("milk", 1.33M);
            store.Add("water", 1.30M);
            store.Add("beer", 0.95M);
            store.Add("cheese", 8.5M);
            store.Add("muffin", 0.5M);

            store.EachProductInRange(0.95M, 2M, Console.WriteLine);

            // Uncomment bellow to test the 500 000 scenraio :)
            // var products = new[] { "apples", "bananas", "milk", "water", "beer", "cheese", "muffin" };
            // var prices = new decimal[] { 0.5M, 8.5M, 0.95M, 1.3M, 1.33M, 1.2M, 2.52M };
            // 
            // var store = new ProductStore();
            // 
            // for (int i = 0; i < 500000; i++)
            // {
            //     store.Add(products[i % 7], prices[i % 7] + (i % 10));
            // }
            // 
            // for (int i = 0; i < 10000; i++)
            // {
            //     store.EachProductInRange(i % 10 - 1, i % 10, Console.WriteLine);
            // }
            // 
            // Console.WriteLine("done");
        }
    }
}
