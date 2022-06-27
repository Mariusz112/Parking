using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibaryWeb.Data;
using LibaryWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibaryWeb.Pages.Categories;

public class IndexAuthors : PageModel
{
    private readonly ApplicationDbContext _dbA;

    public IEnumerable<Category> Categories { get; set; }
    public IndexAuthors(ApplicationDbContext db)
    {
        _dbA = db;
    }

    public void OnGet()
    {
        Categories = _dbA.Category;
    }
}
