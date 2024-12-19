using System.ComponentModel.DataAnnotations;

public class RockEntity
{
    public int Id{get;set;}

    [Required]
    [MinLength(2)]
    public string Name {get;set;}

    [Required]
    public double Density {get;set;}
    [Required]
    public int Hardness {get;set;}

    [Required]
    [MinLength(2)]
    public string Formula {get;set;}

    public int Month {get;set;}

    public bool Favorible {get;set;}

    public string ImageFileName {get;set;}
}