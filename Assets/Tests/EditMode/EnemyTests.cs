using NUnit.Framework;
using SpaceDefender.Core;

[TestFixture]
public class EnemyTests
{
    [Test]
    public void TakeDamage_WhenKilled_SetsIsAliveToFalse() 
    {
        var enemy = new Enemy();
        enemy.TakeDamage(50);
        Assert.IsFalse(enemy.IsAlive);
    }

    [Test]
    public void GetReward_WhenAlreadyDead_ReturnsZero() 
    {
        var enemy = new Enemy();
        Assert.AreEqual(0, enemy.GetReward());
        enemy.TakeDamage(50);
        Assert.AreEqual(100, enemy.GetReward());
    }
}