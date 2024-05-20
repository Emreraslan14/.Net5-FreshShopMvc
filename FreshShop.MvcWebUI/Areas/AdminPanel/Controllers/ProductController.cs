using FreshShop.Business.Abstract;
using FreshShop.Model.Entity;
using FreshShop.Model.ViewModels;
using FreshShop.MvcWebUI.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FreshShop.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private readonly IProductBs _productBs;
        private readonly IProductPhotoBs _productPhotoBs;
        private readonly ICategoryBs _categoryBs;
        public ProductController(IProductBs productBs, IProductPhotoBs productPhotoBs , ICategoryBs categoryBs)
        {
            _productBs = productBs;
            _productPhotoBs = productPhotoBs;
            _categoryBs = categoryBs;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult New()
        {
            List<SelectListItem> categories =
                _categoryBs.GetAll().Select(x => new SelectListItem()
                {
                    Text = x.CategoryName,
                    Value = x.ID.ToString()
                }).ToList();

            categories.Insert(0, new SelectListItem() { Text="Seçiniz..." , Value ="-1"});

            return View(categories);
        }

        [HttpPost]
        public IActionResult New(NewProductVm vm)
        {
            Product p = new Product();
            p.CategoryID = vm.CategoryID;
            p.Discount = vm.Discount;
            p.ProductName = vm.ProductName;
            p.ShortDescription = vm.ShortDescription;
            p.Price = vm.Price;

            _productBs.Insert(p);

            return Json(new { isOk = true , productID = p.ID });
        }

        [HttpPost]
        public IActionResult PhotoUpload()
        {
            IFormFileCollection files = Request.Form.Files;

            var ProductId =Convert.ToInt32(Request.Form["prdID"].ToString());

            if (files.Count > 0)
            {
                foreach (var file in files)
                {
                    var randomFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(file.FileName));

                    string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminPanelContent/images/ProductPhotos", randomFileName);

                    using (var stream = new FileStream(uploadPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    ProductPhoto pH = new ProductPhoto();
                    pH.ProductID = ProductId;
                    pH.PhotoPath = "/AdminPanelContent/images/ProductPhotos/" + randomFileName;

                    _productPhotoBs.Insert(pH);
                }

                return Json(new { isOk = true});
            }

            return Json(new { isOk = false });
        }
    }
}
