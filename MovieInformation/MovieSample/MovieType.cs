using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieSample
{
    class MovieType
    {
        public int MovieTypeMethod(string typeMoveiString)
        {

            int type = 0;
            try
            {

           
            if (typeMoveiString == "Adventure") type = 1;
            if (typeMoveiString == "Comedy") type = 2;
            if (typeMoveiString == "Action") type = 3;
            if (typeMoveiString == "Cartoon") type = 4;
            if (typeMoveiString == "Romantic") type = 5;
            if (typeMoveiString == "Fantasy") type = 6;
            if (typeMoveiString == "Thriller") type = 7;
            if (typeMoveiString == "Historic") type = 8;
            if (typeMoveiString == "Drama") type = 9;
            if (typeMoveiString == "Horor") type = 10;
            if (typeMoveiString == "Crime") type = 11;
            if (typeMoveiString == "Biografy") type = 12;
            
            }
            catch (Exception)
            {

               
            }
            return type;
        }
    }
}
