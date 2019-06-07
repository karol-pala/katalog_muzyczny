using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog_Muzyczny
{
    
    class ShortAlbum
    {
        private string name;
        private string artist;
        private string style;
        public ShortAlbum() { }
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
    }
}
