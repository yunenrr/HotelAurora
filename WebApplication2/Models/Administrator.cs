using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Administrator
    {
        //declaracion de variables
        private int idtbuseradmin;
        private string nameuseradmin;
        private string emailuseradmin;
        private string passworduseradmin;

        //constructor
        public Administrator()
        {
            this.idtbuseradmin = 0;
            this.nameuseradmin = "";
            this.emailuseradmin = "";
            this.passworduseradmin = "";
        }

        //constructor sobrecargado
        public Administrator(int idtbuseradmin, string nameuseradmin, string emailuseradmin, string passworduseradmin)
        {
            this.idtbuseradmin = idtbuseradmin;
            this.nameuseradmin = nameuseradmin;
            this.emailuseradmin = emailuseradmin;
            this.passworduseradmin = passworduseradmin;
        }

        //metodos accesores
        public int Idtbuseradmin
        {
            get
            {
                return idtbuseradmin;
            }

            set
            {
                idtbuseradmin = value;
            }
        }
  
        public string Nameuseradmin
        {
            get
            {
                return nameuseradmin;
            }

            set
            {
                nameuseradmin = value;
            }
        }

        public string Emailuseradmin
        {
            get
            {
                return emailuseradmin;
            }

            set
            {
                emailuseradmin = value;
            }
        }

        public string Passworduseradmin
        {
            get
            {
                return passworduseradmin;
            }

            set
            {
                passworduseradmin = value;
            }
        }


    }
}