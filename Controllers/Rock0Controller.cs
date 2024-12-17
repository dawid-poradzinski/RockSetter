using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class Rock0Controller : Controller
{
    private readonly IRockService _rockService;

    public Rock0Controller(IRockService rockService)
    {
        _rockService = rockService;
    }

    public IActionResult Index()
    {

        List<RockBasicEntity> rocks = _rockService.GetAllRocks().Select(rock => RockMapper.ToBasic(rock)).ToList();

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
}