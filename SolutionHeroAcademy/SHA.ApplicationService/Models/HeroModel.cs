namespace SHA.ApplicationService.Models;

public class Hero
{
    public Guid ID { get; set; }
    public required string Name { get; set; }
    public required string Skill { get; set; }
    public required string History { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
}