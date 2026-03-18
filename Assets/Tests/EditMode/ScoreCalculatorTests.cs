using NUnit.Framework;
using SpaceDefender.Core;

[TestFixture]
public class ScoreCalculatorTests
{
    private ScoreCalculator _calc;

    [SetUp] public void SetUp() => _calc = new ScoreCalculator();

    [Test] public void Calculate_WithZeroKills_ReturnsZero() => Assert.AreEqual(0, _calc.Calculate(0, 10)); // T09

    [Test]
    public void ApplyCombo_With3Kills_IncreasesMultiplier() 
    {
        _calc.ApplyCombo(3);
        Assert.AreEqual(2, _calc.Multiplier);
    }

    [Test]
    public void ResetMultiplier_AfterCombo_SetsMultiplierToOne() 
    {
        _calc.ApplyCombo(3);
        _calc.ResetMultiplier();
        Assert.AreEqual(1, _calc.Multiplier);
    }

    [Test]
    public void Calculate_AfterComboAndReset_UsesBaseMultiplier() 
    {
        _calc.ApplyCombo(3);
        _calc.ResetMultiplier();
        int result = _calc.Calculate(5, 10);
        Assert.AreEqual(50, result);
    }
}