using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableReservationWinFormsApp
{
    class Reservation
    {
        string nameOfGuest;
        int numberOfGuest;
        DateTime arrivalDate;
        int arrivalHour;
        bool regularGuest;

        public string NameOfGuest
        {
            get { return nameOfGuest; }
            set { nameOfGuest = value; }
        }

        public int NumberOfGuest
        {
            get { return numberOfGuest; }
            set { numberOfGuest = value; }
        }

        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        public int ArrivalHour
        {
            get { return arrivalHour; }
            set { arrivalHour = value; }
        }

        public bool RegularGuest
        {
            get { return regularGuest; }
            set { regularGuest = value; }
        }
    }
}
