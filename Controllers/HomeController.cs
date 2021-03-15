﻿using DI.LifeTimes.WebApp.Models;
using DI.LifeTimes.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DI.LifeTimes.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly ITransientOperation _transientOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly IMyService _myService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(
            ILogger<HomeController> logger,
            ISingletonOperation singletonOperation,
            ITransientOperation transientOperation,            
            IScopedOperation scopedOperation,
            IMyService myService)
        {
            _singletonOperation = singletonOperation;

            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _myService = myService;

            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogWarning("Singleton: " + _singletonOperation.Id);
            _logger.LogWarning("Transient: " + _transientOperation.Id);
            _logger.LogWarning("Scoped: " + _scopedOperation.Id);

            _logger.LogWarning("MyService Singleton: " + _myService.getSingleton()); ;
            _logger.LogWarning("MyService Transient: " + _myService.getTransient());
            _logger.LogWarning("MyService Scoped: " + _myService.getScoped());

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
