using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique.Classe
{
    internal class Commande
    {
        static int auto_id = 0;

        private int _id;
        private DateTime date;
        private ProductLine[] line;
        private Client client;
        

        public Commande()
        {

            this._id = auto_id++;
            this.date = DateTime.Now;
        }

        public Commande(DateTime date, ProductLine[] line, Client client) : this()
        {

            this.date = date;
            this.line = line;
            this.client = client;
        }

        public int getId()
        {
            return this._id;
        }

        public DateTime Date {
            get => date;

            set => this.date = value;
        
        }


        public ProductLine[] Line 
        { 
            get => line;
            
            set => this.line = value; 
        }

        public Client Client
        {
            get { return client; }
            set => this.client = value;
        }


        public double Sum()
        {

            double sum = 0;

            for (int i = 0; i < line.Length; i++)
            {
                sum+=line[i].TotalPrice();
            }

            return sum;
        }
    }
}
