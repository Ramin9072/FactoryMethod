using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Model
{
    public sealed class Product
    {
        private Product(decimal retailPrice, string productName)
        {
            RetailPrice = retailPrice;
            ProductName = productName;
        }

        public decimal RetailPrice { get; }
        public string ProductName { get; }

        public class Builder
        {
            private decimal _retailPrice;
            private string _productName;

            public Builder ProductName(string productName)
            {
                _productName = productName;
                return this;
            }

            public Builder RetailPrice(decimal retailPrice)
            {
                _retailPrice = retailPrice;
                return this;
            }

            public Product Create()
            {
                return new Product(_retailPrice, _productName);
            }
        }

    }
}
