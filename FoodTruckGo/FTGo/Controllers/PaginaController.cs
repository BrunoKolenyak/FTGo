﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FTGo.Controllers
{
    public class PaginaController : Controller
    {
        // GET: Pagina
        public ActionResult Index()
        {
            return View();
        }
    }
}