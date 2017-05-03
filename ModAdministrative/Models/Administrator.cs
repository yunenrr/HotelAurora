using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ModAdministrative.Models
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

        [Key]
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

        [Required (ErrorMessage ="Requiere el nombre de usuario")]
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

        [Required(ErrorMessage = "Requiere el email de usuario")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Por favor ingrese un correo valido")]
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

        [Required(ErrorMessage = "Requiere la contraseña de usuario")]
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