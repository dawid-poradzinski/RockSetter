public interface IRockService 
{
    void Add(RockEntity rock);
    void Update(RockEntity rock);
    void Delete(int id);
    List<RockEntity> GetAllRocks();
    RockEntity? GetById(int id);

    RockEntity? GetByName(string name);
}