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
        private List<ProductLine> lines = { };
        private Client client;
        public static List<Commande> commande_list = { };

        public Commande()
        {

            this._id = auto_id++;
            this.date = DateTime.Now;
        }

        public Commande(DateTime date, List<ProductLine> lines, Client client) : this()
        {

            this.date = date;
            this.lines = lines;
            int i = Client.clients.FindIndex(cl => cl.Code == client.Code);

            if (i >= 0 || i < Client.clients.Count()) {
                this.client = client;
            }

            commande_list.Add(this);
        }

        public int getId()
        {
            return this._id;
        }

        public DateTime Date {
            get => date;

            set => this.date = value;
        
        }


        public List<ProductLine> Lines 
        { 
            get => lines;
            
            set => this.lines = value; 
        }

        public Client Client
        {
            get { return client; }
            set => this.client = value;
        }


        public double Total()
        {

            double sum = 0;
            lines.ForEach(l => sum+=l.TotalLine());

            return sum;
        }
    }
}
