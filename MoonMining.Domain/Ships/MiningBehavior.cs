using MoonMining.Domain.Ships;

namespace MoonMining.Domain;

public class FixedYieldBehavior : IMiningBehavior
{
    private readonly decimal _yield;
    public FixedYieldBehavior(decimal yield) => _yield = yield;
    public decimal GetYieldPerCycle(int cycleIndexInTrip) => _yield;
}

public class ProspectYieldBehavior : IMiningBehavior
{
    public decimal GetYieldPerCycle(int cycleIndexInTrip)
    {
        return cycleIndexInTrip == 0 ? 75m : 150m;
    }
}

public class NoMiningBehavior : IMiningBehavior
{
    public decimal GetYieldPerCycle(int cycleIndexInTrip) => 0m;
}