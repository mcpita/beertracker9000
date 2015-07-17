using System.Web.UI.WebControls;
using BeerTracker9000.Models;

namespace BeerTracker9000.Services
{
    public class BeerService
    {
        public bool AddBeer(Beer beer)
        {
            if (string.IsNullOrEmpty(beer.Name))
            {
                return false;
                
            }
            return true;
        }
    }
}