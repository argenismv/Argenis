using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface IPieRepository // As a reminder, interfaces have to be implemented by code in a solid class later on
    {
        IEnumerable<Pie> GetAllPies(); // Method, Enumerable to get all pies
        Pie GetPieByID(int pieID); // Get Pie name by passing an integer ID
    }
}
