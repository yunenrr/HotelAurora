using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Mail
    {
        private string from;
        private string to;
        private string subject;
        private string content;

        public Mail()
        {
            this.from = "";
            this.to = "";
            this.subject = "";
            this.content = "";
        }

        public Mail(string from, string to, string subject, string content)
        {
            this.from = from;
            this.to = to;
            this.subject = subject;
            this.content = content;
        }

        public string From
        {
            get
            {
                return from;
            }

            set
            {
                from = value;
            }
        }

        public string To
        {
            get
            {
                return to;
            }

            set
            {
                to = value;
            }
        }

        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

    }
}