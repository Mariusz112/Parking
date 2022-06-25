using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibaryWeb.Model;
using LibaryWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibaryWeb.Pages.Categories;


public class EditModel : PageModel
{
    private readonly ApplicationDbContext _db;
    [BindProperty]
    public Category Category { get; set; }

    public EditModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet(int id)
    {
        Category = _db.Category.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            _db.Category.Update(Category);
            await _db.SaveChangesAsync();
            TempData["success"] = "Book data updated succesfully";
            return RedirectToPage("Index");
        }
        return Page();
    }
}
