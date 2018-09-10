using System;
using System.Collections.Generic;
using System.Text;

namespace DeveloperTestXF
{
    public class Shoes
    {
        public string ShoeImage { get; set; }
        public string ShoeName { get; set; }
        public string SubTitle { get; set; }
        public string Distance { get; set; }
        public bool IsFavourite { get; set; }
        public string FavouriteImage
        {
            get
            {
                if (IsFavourite)
                    return "star_selected.png";
                else
                    return "star_not_selected.png";
            }
        }
    }
}
