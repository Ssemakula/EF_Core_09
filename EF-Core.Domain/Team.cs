namespace EF_Core.Domain;

public class Team : BaseDomainModel
{
    public int ID { get; set; }
    public string? Name { get; set; }
}
