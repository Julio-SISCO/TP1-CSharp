using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique.Classe
{
    internal class Client {

        static int auto_code = 0;

        private int code;
        private string name;
        private string surname;
        private DateTime d_naiss;


        public Client(){
            auto_code++;
                this.code = auto_code;
        }

        public Client(string name) : this(){

            this.name = name;
            this.surname = "Non renseigné";
            this.d_naiss = DateTime.Today;
        }

        public Client(string name, string surname, DateTime d_naiss) : this(name){

            this.surname = surname;
            this.d_naiss = d_naiss;
        }

        public string FullName(){

            return surname+' '+name;
        }

        public int Code{

            get => code; 
        }

        public string Name {

            get => name;

            set {
                if(value != null) {

                    name = value;
                }
            }
        }

        public string Surname {

            get => surname;

            set {
                if (value != null){

                    surname = value;
                }
            }
        }

        public DateTime D_naiss {

            get => d_naiss;

            set { d_naiss = value; }
        }
    }
}
