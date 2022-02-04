 using Microsoft.AspNetCore.Mvc;
 using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesPizza.Pages
 {
    public class PizzaModel : PageModel
     {
         public void OnGet()
        {
        }
     }
 }
// using RazorPagesPizza.Models;
// using RazorPagesPizza.Services;
// public string GlutenFreeText(Pizza pizza)
// {
//     if (pizza.IsGlutenFree)
//         return "Gluten Free";
//     return "Not Gluten Free";
// }
// public IActionResult OnPost()
// {
//     if (!ModelState.IsValid)
//     {
//         return Page();
//     }
//     PizzaService.Add(NewPizza);
//     return RedirectToAction("Get");
// }