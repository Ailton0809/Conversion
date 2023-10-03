using Conversion.Models.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Conversion.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index(IndexViewModel vm)
        {
            if (vm == null)
                return NotFound();
           
            if (vm.Valor == 0)
                return View(vm);
            
            if (vm.Moneda == null)
                return View(vm);
            
            if (vm.Moneda == "USD")
            {vm.Resultado = vm.Valor / 20m;}

            if (vm.Moneda == "MXN")
            { vm.Resultado = vm.Valor * 20m;}
            
            return View(vm);
        }
    }
}
