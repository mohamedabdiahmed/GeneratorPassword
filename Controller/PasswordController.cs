using Microsoft.AspNetCore.Mvc;

public class PasswordController : Controller
{
    private readonly PasswordGeneratorService _passwordGeneratorService;

    public PasswordController(PasswordGeneratorService passwordGeneratorService)
    {
        _passwordGeneratorService = passwordGeneratorService;
    }

    [HttpGet]
    public IActionResult Generate()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Generate(int length)
    {
        if (length <= 0)
        {
            ModelState.AddModelError("length", "Length must be greater than 0.");
            return View();
        }

        var password = _passwordGeneratorService.GeneratePassword(length);
        ViewBag.GeneratedPassword = password;
        return View();
    }
}
