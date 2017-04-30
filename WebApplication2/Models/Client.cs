using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Client
    {
        //declaracion de variables
        private int idtbclient;
        private string dni;
        private string name;
        private string surnames;
        private string email;
        private string phone;

        //constructor
        public Client()
        {
            this.idtbclient = 0;
            this.dni = "";
            this.name = "";
            this.surnames = "";
            this.email = "";
            this.phone = "";
        }

        //constructor sobrecargado
        public Client(int idtbclient, string dni, string name, string surnames, string email, string phone)
        {
            this.idtbclient = idtbclient;
            this.dni = dni;
            this.name = name;
            this.surnames = surnames;
            this.email = email;
            this.phone = phone;
        }

        //metodos accesores
        public int Idtbclient
        {
            get
            {
                return idtbclient;
            }

            set
            {
                idtbclient = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surnames
        {
            get
            {
                return surnames;
            }

            set
            {
                surnames = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

    }
}
