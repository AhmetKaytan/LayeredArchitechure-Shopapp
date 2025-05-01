using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.data.Abstract;

namespace shopapp.webui.Controllers
{
    public class HomeController : Controller
    {

        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }
        //localhost:5000/home/index
        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel() { Products = _productService.GetAll() };

            return View(productViewModel);
        }

        //localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}