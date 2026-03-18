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
}