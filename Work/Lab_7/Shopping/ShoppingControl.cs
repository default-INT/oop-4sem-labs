using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public enum Discaunt
    {
        WithoutDiscaunt,
        Discaunt10,
        Discaunt25,
        Discaunt50
    }

    public class ShoppingControl
    {
        List<Product> products = new List<Product>();

        public string AddProduct(string name, double price)
        {
            string msg = null;
            Discaunt discaunt = CalculateDiscaunt(name);

            if (discaunt == Discaunt.WithoutDiscaunt)
            {
                Product product = new Product(name, price);
                products.Add(product);
                msg = "Покупка успешно добавлена без скидки по цене " + product.price +".\n";
            }
            else if (discaunt == Discaunt.Discaunt10)
            {
                ProductDiscaunt10 product = new ProductDiscaunt10(name, price);
                products.Add(product);
                msg = "Покупка успешно добавлена со скидкой по цене " + product.price + ".\n";
            }
            else if (discaunt == Discaunt.Discaunt25)
            {
                ProductDiscaunt25 product = new ProductDiscaunt25(name, price);
                products.Add(product);
                msg = "Покупка успешно добавлена со скидкой 25% по цене " + product.price + ".\n";
            }
            else if (discaunt == Discaunt.Discaunt50)
            {
                ProductDiscaunt50 product = new ProductDiscaunt50(name, price);
                products.Add(product);
                msg = "Покупка успешно добавлена со скидкой 50% по цене " + product.price + ".\n";
            }
                
            return msg;
        }

        public string DeleteProduct(string name)
        {
            int n = products.Count;
            name = name.ToLower();
            Product product;
            for (int i = n - 1; i >= 0; i--)
            {
                if (products[i].name.ToLower() == name)
                {
                    product = products[i];
                    products.RemoveAt(i);
                    return "Товар удалён, его стоимость " + product.price + "\n";
                }
            }
            return "Товар с таким названием не найден";
        }

        public string SummAllProduct()
        {
            double sum = 0;
            foreach (Product product in products)
            {
                sum += product.price;
            }
            return "Сумма всех покупок равна " + sum + "\n";
        }

        public double AverageCostProduct(string name)
        {
            int k = 0;
            double sum = 0;
            name = name.ToLower();

            foreach (Product product in products)
            {
                if (product.name.ToLower() == name)
                {
                    sum += product.price;
                    k++;
                }
            }
            if (k > 0) return Math.Round(sum / k, 2);
            else return 0;
        }

        public List<string> GetProductsName()
        {
            List<string> productsName = new List<string>();

            foreach (Product product in products)
            {
                bool repeate = false;
                foreach(string name in productsName)
                {
                    if (name.ToLower() == product.name.ToLower()) repeate = true;
                }
                if (!repeate) productsName.Add(product.name);
            }
            if (productsName.Count > 0) return productsName;
            else return null;
        }

        public int CountProduct(string name)
        {
            int k = 0;
            name = name.ToLower();

            foreach (Product product in products)
            {
                if (product.name.ToLower() == name) k++;
            }

            return k;
        }

        public string CountProductDiscaunt()
        {
            int k = 0;

            foreach (Product product in products)
            {
                bool expression = product is ProductDiscaunt10 || product is ProductDiscaunt25
                    || product is ProductDiscaunt50;
                if (expression) k++;
            }

            return "Количество покупок купленных со скидками равняется: " + k + "\n";
        }

        public string[,] GetProductList()
        {
            int n = products.Count;
            string[,] productTable = new string[n, 2];

            for (int i = 0; i < n; i++)
            {
                productTable[i, 0] = products[i].name;
                productTable[i, 1] = products[i].price.ToString();
            }
            if (n > 0) return productTable;
            else return null;
        }

        private Discaunt CalculateDiscaunt(string name)
        {
            int k = 0;
            name = name.ToLower();
            foreach (Product product in products)
            {
                if (product.name.ToLower() == name) k++;
            }
            if (k <= 2) return Discaunt.Discaunt10;
            else if (k <= 5) return Discaunt.Discaunt25;
            else if (k > 5) return Discaunt.Discaunt50;
            return Discaunt.WithoutDiscaunt;
        }
        
    }
}
