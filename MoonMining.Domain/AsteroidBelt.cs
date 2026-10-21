namespace MoonMining.Domain;

public record AsteroidBelt
{
    public string Name { get; }
    public decimal Distance { get; }
    public Ore Ore { get; }

    public AsteroidBelt(string name, decimal distance, Ore ore)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Название пояса не может быть пустым.", nameof(name));
        if (distance <= 0)
            throw new ArgumentException("Расстояние до пояса должно быть положительным.", nameof(distance));
        
        Name = name;
        Distance = distance;
        Ore = ore ?? throw new ArgumentNullException(nameof(ore), "Руда не может быть null.");
    }
}