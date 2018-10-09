using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository // Implement the IPieRepository interface into the class MockPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            new Pie { ID = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "Apple Pie is very long" };
            new Pie { ID = 2, Name = "Blueberry Cheese Cake", Price = 19.99M, ShortDescription = "You'll love it", LongDescription = "Blueberry Cheese Cake is very long" };
            new Pie { ID = 3, Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain pleasure.", LongDescription = "Cheese Cake is very long" };
            new Pie { ID = 4, Name = "Cherry Pie", Price = 15.95M, ShortDescription = "A summer classic!", LongDescription = "Cherry Pie is very long" };
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieByID(int pieID)
        {
            return _pies.FirstOrDefault(p => p.ID == pieID); //  runs parameter p is equal to the p pie ID if it's equal to a pie ID
        }
    }
}
