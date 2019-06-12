using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog_Muzyczny
{
    class Album
    {
        
        private string name;
        private string artist;
        private string style;
        private string label;
        private string format;
        private int year;
        private string country;
        private float cost;
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
        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }
        public string Style
        {
            get
            {
                return style;
            }
            set
            {
                style = value;
            }
        }
        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
            }
        }
        public string Format
        {
            get
            {
                return format;
            }
            set
            {
                format = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public float Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        
        public Album()
        {
        }
        public string[] GetAlbum()
        {
            string[] s = new string[] { name, artist, style, label, format, year.ToString(), country, cost.ToString() };
            return s;
        }
        public string[] GetShortAlbum()
        {
            string[] s = new string[] { name, artist, style };
            return s;
        }
    }
}
