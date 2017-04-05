using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Hotel
    {

        private int idHotel;
        private string nameHotel;
        private string basicInformation;
        private string history;
        private string mission;
        private string vission;
        private string location;

        public Hotel()
        {
            this.idHotel = -1;
            this.nameHotel = "";
            this.basicInformation = "";
            this.history = "";
            this.mission = "";
            this.vission = "";
            this.location = "";
        }

        public Hotel(int idHotel, string nameHotel, string basicInformation, string history, string mission, string vission, string location)
        {
            this.idHotel = idHotel;
            this.nameHotel = nameHotel;
            this.basicInformation = basicInformation;
            this.history = history;
            this.mission = mission;
            this.vission = vission;
            this.location = location;
        }

        public int IdHotel
        {
            get
            {
                return idHotel;
            }

            set
            {
                idHotel = value;
            }
        }

        public string NameHotel
        {
            get
            {
                return nameHotel;
            }

            set
            {
                nameHotel = value;
            }
        }

        public string BasicInformation
        {
            get
            {
                return basicInformation;
            }

            set
            {
                basicInformation = value;
            }
        }

        public string History
        {
            get
            {
                return history;
            }

            set
            {
                history = value;
            }
        }

        public string Mission
        {
            get
            {
                return mission;
            }

            set
            {
                mission = value;
            }
        }

        public string Vission
        {
            get
            {
                return vission;
            }

            set
            {
                vission = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

    }
}