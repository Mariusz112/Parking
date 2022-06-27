using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibaryWeb.Model;
using LibaryWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibaryWeb.Pages.Authors;


public class EditAuthor : PageModel
{
    private readonly ApplicationDbContext _dbA;
    [BindProperty]
    public Author Author { get; set; }

    public EditAuthor(ApplicationDbContext db)
    {
        _dbA = db;
    }
    public void OnGet(int id)
    {
        Author = _dbA.Author.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            _dbA.Author.Update(Author);
            await _dbA.SaveChangesAsync();
            TempData["success"] = "Author data updated succesfully";
            return RedirectToPage("Index");
        }
        return Page();
    }
}
