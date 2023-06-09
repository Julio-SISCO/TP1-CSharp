﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique.Classe
{
    internal class Product {
        private string codeProd;
        private string label;
        private int qteStk;
        private double price;
        public static List<Product> products = { };
        static int num = 0;

        public Product(){
            this.codeProd = "Product"+num.ToString();
        }
        public Product(int qteStk, double price) : this()
        {
            if (qteStk < 0)
            {

                this.qteStk = 0;
            }
            else
            {
                this.qteStk = qteStk;
            }

            if (price < 0)
            {

                this.price = 0;
            }
            else
            {
                this.price = price;
            }
        }

        public Product(string codeProd, string label, int qteStk, double price) : this(qteStk, price)
        {

            this.codeProd = codeProd;
            this.label = label;

            Product.products.Add(this);
        }

        public string CodeProd
        {
            get => this.codeProd;
            set => codeProd = value;
        }

        public string Label
        {
            set => label = value;
            get => this.label;
        }

        public int QteStk
        {

            set {
                if (value > 0)
                {
                    qteStk = value;
                }
            }
            get => this.qteStk;
        }

        public double Price
        {
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
            get => this.price;
        }

    }
}
