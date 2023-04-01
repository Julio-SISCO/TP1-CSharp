using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique.Classe
{
    internal class ProductLine
    {
        static int auto_id = 0;

        private int _id;
        private DateTime date;
        private int qte;
        private Product product;


        public ProductLine() {

            auto_id++;

            this._id = auto_id;
            date = DateTime.Now;
            this.qte = 1;
        }

        public ProductLine(DateTime date, int qte, Product product) : this() {

            this.date = date;
            this.qte = qte;
            this.product = product;
        }

        public int getId()
        {
            return this._id;
        }

        public DateTime Date { 

            get { return this.date; }

            set { this.date = value; }
        }


        public int Qte
        {
            get => this.qte;
            set
            {
                if(value > 0)
                {
                    this.qte = value;
                }
            }
        }


        public Product Product { 
            
            get => this.product;

            set => this.product = value;
        
        }


        public double TotalPrice()
        {
            return this.product.Price * this.Qte;
        }
    }
}
