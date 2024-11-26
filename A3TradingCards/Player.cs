using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A3TradingCards
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }

        public Image Photo { get; set; }
        public string Skills { get; set; }
        
        public string Nationality { get; set; }
        public string GrandTourAppearances { get; set; }

        public int TeamId { get; set; }
        public string imageId { get; set; }
        public void GeneratePhoto()
        {
            Photo = System.Drawing.Image.FromFile($"photos/{imageId}.jpg");
        }
        public override bool Equals(object obj)
        {
            if (obj is Player other)
            {
                return Id == other.Id &&
                       FullName == other.FullName &&
                       DOB == other.DOB &&
                       Photo == other.Photo &&
                       Skills == other.Skills &&
                       Nationality == other.Nationality &&
                       GrandTourAppearances == other.GrandTourAppearances &&
                       TeamId == other.TeamId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id,FullName, DOB, Photo, Skills, Nationality, GrandTourAppearances, TeamId);
        }

    }
}
