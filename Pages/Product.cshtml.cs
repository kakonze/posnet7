using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace posnet7.Pages;

public class ProductModel : PageModel
{
    private readonly ILogger<ProductModel> _logger;

    public ProductModel(ILogger<ProductModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

