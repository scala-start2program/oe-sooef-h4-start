using System;
using System.Collections.Generic;
using System.Text;

namespace Scala.M2.Opdracht03.Core
{
    public class Vakantiehuis
    {
        private string adres; 
        private string huisnaam;
        private string gemeente;
        private decimal prijsPerNacht;
        private byte maxPersonen;

        public string  Huisnaam
        {
            get { return huisnaam; }
            set 
            {
                value = value.Trim();
                if (value == "")
                {
                    throw new Exception("Huisnaam kan niet leeg zijn");
                }
                else
                {
                    huisnaam = value;
                }
            }
        }
        public string Adres  // straat + huisnummer
        {
            get { return adres; }
            set { adres = value; }
        }
        public string Gemeente // postcode + gemeente
        {
            get { return gemeente; }
            set { gemeente = value; }
        }
        public decimal PrijsPerNacht
        {
            get { return prijsPerNacht; }
            set 
            {
                if (value < 0)
                    value = 0;
                prijsPerNacht = value; 
            }
        }
        public byte MaxPersonen
        {
            get { return maxPersonen; }
            set 
            {
                if (value > 12)
                    value = 12;
                maxPersonen = value; 
            }
        }

        public Vakantiehuis()
        { }
        public Vakantiehuis(string huisnaam, string adres, string gemeente, decimal prijsPerNacht, byte maxPersonen)
        {
            Huisnaam = huisnaam;
            this.adres = adres;
            this.gemeente = gemeente;
            PrijsPerNacht = prijsPerNacht;
            MaxPersonen = maxPersonen;
        }
        public override string ToString()
        {
            return $"{huisnaam} - {gemeente}";
        }


    }
}
