namespace EF_Core.Domain;


public class Coach :BaseDomainModel
{
    public int ID { get; set; }
    public string? Name { get; set; }
}
