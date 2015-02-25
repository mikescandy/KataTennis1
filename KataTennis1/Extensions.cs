using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis1
{
   public static class Extensions
    {
       public static string ToTennisScore(this int score)
       {
           switch (score)
           {
               case 0:
                   return "love";
               case 1:
                   return "fifteen";
               case 2:
                   return "thiry";
               case 3:
                   return "forty";
               default:
                   return "love";
                   break;
           }
       }
    }
}
