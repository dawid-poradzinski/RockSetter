public interface IRockService 
{
    void Add(RockEntity rock);
    void Update(RockEntity rock);
    void Delete(RockEntity rock);
    List<RockEntity> GetAllRocks();
    RockEntity? GetById(int id);

    RockEntity? GetByName(string name);
}