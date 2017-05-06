using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace Helper
{
    public class SessionHelper
    {
        /**
         * Nos indica si un usuario existe en sesión ya
         */
        public static bool existUserInSession()
        {
            return HttpContext.Current.User.Identity.IsAuthenticated;
        }//Fin del métoo

        /**
         * Método que destruye la sesión del usuario
         */
        public static void destroyUserSession()
        {
            FormsAuthentication.SignOut();
        }//Fin del método

        /**
         * Método que retorna el identificador de un usuario
         */
        public static int getUser()
        {
            int userID = 0;

            if (HttpContext.Current.User != null && HttpContext.Current.User.Identity is FormsIdentity)
            {
                FormsAuthenticationTicket ticket = ((FormsIdentity)HttpContext.Current.User.Identity).Ticket;
                if (ticket != null)
                {
                    userID = Convert.ToInt32(ticket.UserData);
                }//Fin del if
            }//Fin del if
            return userID;
        }//Fin del método

        /**
         * Método que agrega un usuario a sesión
         */
        public static void addUserToSession(string id)
        {
            bool persist = true;
            var cookie = FormsAuthentication.GetAuthCookie("user", persist);

            cookie.Name = FormsAuthentication.FormsCookieName;
            cookie.Expires = DateTime.Now.AddMonths(3);

            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            var newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, id);

            cookie.Value = FormsAuthentication.Encrypt(newTicket);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }//Fin del método
    }//Fin de la clase
}