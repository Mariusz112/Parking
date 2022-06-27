using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibaryWeb.Model;
using LibaryWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibaryWeb.Pages.Authors;


public class CreateAuthor : PageModel
{
    private readonly ApplicationDbContext _dbA;
    [BindProperty]
    public Author Author { get; set; }

    public CreateAuthor(ApplicationDbContext db)
    {
        _dbA = db;
    }
    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost()
    {

        if (ModelState.IsValid)
        {
            await _dbA.Author.AddAsync(Author);
            await _dbA.SaveChangesAsync();
            TempData["success"] = "Author added succesfully";
            return RedirectToPage("Index");
        }
        return Page();
    }
}
