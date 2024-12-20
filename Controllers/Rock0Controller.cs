using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        ModelState.Clear();
        rock.ImageFileName = "default";
        TryValidateModel(rock);
        
        if(ModelState.IsValid)
        {

            _rockService.Add(rock);
            return RedirectToAction(nameof(Details), new {rock.Id});
        }
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
            return View(rock);
        }

        _rockService.Update(rock);
        return RedirectToAction(nameof(Details));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        _rockService.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}