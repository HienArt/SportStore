﻿using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController (IProductRepository productproductRepository)
        {
            this.repository = productproductRepository;
        }
        // GET: Product
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}