namespace MoonMining.Domain.Fleet;

public interface ICargoPlacementStrategy
{
    bool CanPlace(Ship targetShip, IReadOnlyList<Ship> fleet, decimal amount, IReadOnlyDictionary<Ship, decimal> currentCargo);
    
    IReadOnlyDictionary<Ship, decimal> Place(Ship targetShip, IReadOnlyList<Ship> fleet, decimal amount, IReadOnlyDictionary<Ship, decimal> currentCargo);
}