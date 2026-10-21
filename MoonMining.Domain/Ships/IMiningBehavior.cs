namespace MoonMining.Domain.Ships;

public interface IMiningBehavior
{
    decimal GetYieldPerCycle(int cycleIndexInTrip);
}