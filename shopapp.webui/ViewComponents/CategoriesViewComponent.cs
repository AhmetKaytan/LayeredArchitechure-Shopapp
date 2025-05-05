using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;

namespace shopapp.webui.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private ICategoryService _categoryservice;

        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this._categoryservice = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString() == "List")
            {
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            }
            return View(_categoryservice.GetAll());
        }
    }
}