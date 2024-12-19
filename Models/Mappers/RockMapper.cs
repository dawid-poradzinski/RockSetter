public class RockMapper
{
    public static RockBasicEntity ToBasic(RockEntity rock)
    {
        return new RockBasicEntity()
        {
            Id = rock.Id,
            Name = rock.Name,
            Favorible = rock.Favorible,
            ImageFileName = rock.ImageFileName
        };
    }
}