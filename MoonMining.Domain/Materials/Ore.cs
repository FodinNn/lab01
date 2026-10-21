namespace MoonMining.Domain.Materials;

public record Ore
{
    public string Name { get; }
    public decimal VolumePerUnit { get; }
    
    public IReadOnlyDictionary<Mineral, int> yieldPerPortion { get; }

    public Ore(string name, decimal volumePerUnit, IReadOnlyDictionary<Mineral, int> yieldPerPortion)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Название руды не может быть пустым", nameof(name));
        
        if (volumePerUnit <= 0)
            throw new ArgumentException("Объем единицы руды должен быть положительным.", nameof(volumePerUnit));
        
        if (yieldPerPortion == null || yieldPerPortion.Count == 0)
            throw new ArgumentException("Выход руды не может быть пустым.", nameof(yieldPerPortion));
        
        Name = name;
        VolumePerUnit = volumePerUnit;
        yieldPerPortion = yieldPerPortion;
    }
}