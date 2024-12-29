using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.IO;
using Microsoft.AspNetCore.Http;

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


                if( !System.IO.File.Exists(Path.Combine(_webHost.WebRootPath, "rocks" , $"{rock.ImageFileName}")) )
                {
                    rock.ImageFileName = "default.jpeg";
                }

                return RockMapper.ToBasic(rock);
                
            }
            ).ToList();

        return View(rocks);

    }

    [HttpGet]
    public IActionResult Add()
    {
        return View(new RockEntity());
    }

    [HttpPost]
    public IActionResult Add(RockEntity rock)
    {

        
        if(ModelState.IsValid)
        {
            _rockService.Add(rock);
            return RedirectToAction(nameof(Details), new {rock.Id});
        }
        return View(rock);
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        var rock = _rockService.GetById(id);

        if( !System.IO.File.Exists(Path.Combine(_webHost.WebRootPath, "rocks" , $"{rock.ImageFileName}")) )
        {
            rock.ImageFileName = "default.jpeg";
        }

        return View(rock);
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

    [HttpGet]
    public IActionResult GetImages()
    {
        var images = Directory.GetFiles("wwwroot/rocks").Select(Path.GetFileName).ToList();
        return PartialView("_ImageListPartial", images);
    }

    [HttpPost]
    public IActionResult UploadImage(IFormFile file)
    {
        if (file != null && file.Length > 0)
        {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(_webHost.WebRootPath, "rocks", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return Json(new { fileName });
        }

        return BadRequest("No file uploaded.");
    }
 
}