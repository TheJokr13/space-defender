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
    public void GetReward_WhenAlreadyLooted_ReturnsZero()
    {
        var enemy = new Enemy();
        enemy.TakeDamage(50); 
        enemy.GetReward();

        var secondReward = enemy.GetReward(); 

        Assert.AreEqual(0, secondReward);
    }
}