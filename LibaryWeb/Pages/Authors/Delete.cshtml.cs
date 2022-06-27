using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibaryWeb.Model;
using LibaryWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibaryWeb.Pages.Authors;


public class DeleteAuthor : PageModel
{
    private readonly ApplicationDbContext _dbA;
    [BindProperty]
    public Author Author { get; set; }

    public DeleteAuthor(ApplicationDbContext db)
    {
        _dbA = db;
    }
    public void OnGet(int id)
    {
        Author = _dbA.Author.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
            var AuthorFromDb = _dbA.Author.Find(Author.Id);
            if (AuthorFromDb != null)
            {
                _dbA.Author.Remove(AuthorFromDb);
                await _dbA.SaveChangesAsync();
            TempData["success"] = "Author deleted succesfully";
            return RedirectToPage("Index");
        }

            
        return Page();
    }
}
