using MoonMining.Domain.Ships;

namespace MoonMining.Domain;

public record Ship
{
    public string Name { get; }
    public decimal CargoCapacity { get; }
    public decimal Speed { get; }
    public decimal RentalPerHour { get; }
    public IMiningBehavior MiningBehavior { get; }

    public Ship(string name, decimal cargoCapacity, decimal speed, decimal rentalPerHour, IMiningBehavior miningBehavior)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Название корабля не может быть пустым.", nameof(name));
        if (cargoCapacity <= 0)
            throw new ArgumentException("Объем трюма должен быть положительным.", nameof(cargoCapacity));
        if (speed <= 0)
            throw new ArgumentException("Скорость должна быть положительной.", nameof(speed));
        if (rentalPerHour < 0)
            throw new ArgumentException("Стоимость аренды не может быть отрицательной.", nameof(rentalPerHour));

        Name = name;
        CargoCapacity = cargoCapacity;
        Speed = speed;
        RentalPerHour = rentalPerHour;
        MiningBehavior = miningBehavior ?? throw new ArgumentNullException(nameof(miningBehavior));
    }
}