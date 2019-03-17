using Canteen.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Canteen.Controllers
{
    public class CookShopController: Controller
    {
        private readonly ICookShopRepository _repo;
        

        public CookShopController(ICookShopRepository repo, IHostingEnvironment env)
        { 
            _repo = repo;
        }

        public async Task<IActionResult> CookShopList()
        {
            try
            {
                return PartialView("CookShopList", await _repo.GetAllAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
