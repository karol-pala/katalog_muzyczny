using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog_Muzyczny
{
    class Cost
    {
        private List<Album> albums = new List<Album>();
        private Database DB = new Database();
        public Cost(List<Album> alb)
        {
            albums = alb;
        }
        public List<Album> Albums
        {
            get
            {
                return albums;
            }
        }
        public float MiddleCost()
        {
            double result = 0;
            int i = 0;
            albums.ForEach(delegate(Album album){
                result += album.Cost;
                i++;
            });
            result = result / i;


            result = Math.Round(result, 2);
            return (float)result;
        }

    }
}
