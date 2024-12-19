


using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class EFRockSerivce : IRockService
{

    private readonly AppDbContext _context;

    public EFRockSerivce(AppDbContext context)
    {
        _context = context;
    }

    public void Add(RockEntity rock)
    {
        _context.Add(rock);
        _context.SaveChanges();
    }

    public void Delete(RockEntity rock)
    {
        throw new NotImplementedException();
    }

    public List<RockEntity> GetAllRocks()
    {
        return _context.Rocks.ToList();
    }

    public RockEntity? GetById(int id)
    {
       return _context.Rocks.Find(id);
    }

    public RockEntity? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Update(RockEntity rock)
    {
        _context.Rocks.Update(rock);
        _context.SaveChanges();
    }
}