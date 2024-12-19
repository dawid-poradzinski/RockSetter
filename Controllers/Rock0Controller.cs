using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class Rock0Controller : Controller
{
    private readonly IRockService _rockService;
    private readonly IWebHostEnvironment _webHost;

    public Rock0Controller(IRockService rockService, IWebHostEnvironment webHostEnvironment)
    {
        _rockService = rockService;
        _webHost = webHostEnvironment;
    }

    public IActionResult Index()
    {

        List<RockBasicEntity> rocks = _rockService.GetAllRocks().Select(
            rock => 
            {


                if( !System.IO.File.Exists(Path.Combine(_webHost.WebRootPath, "rocks" , $"{rock.ImageFileName}.jpeg")) )
                {
                    rock.ImageFileName = "default";
                }

                return RockMapper.ToBasic(rock);
                
            }
            ).ToList();

        return View(rocks);

    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(RockEntity rock)
    {
        return View();
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        return View(_rockService.GetById(id));
    }

    [HttpPost]
    public IActionResult Details(RockEntity rock)
    {
        if(!ModelState.IsValid)
        {
            return View();
        }
        _rockService.Update(rock);
        return RedirectToAction(nameof(Index));
    }
}