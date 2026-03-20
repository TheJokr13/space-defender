namespace SpaceDefender.Core
{
    public class Enemy
    {
        public int Health { get; private set; } = 50;
        public bool IsAlive => Health > 0;
        public bool IsLootable = true;

        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
        }

        public int GetReward()
        {
            if (!IsLootable || IsAlive)
            {
                return 0;
            }

            IsLootable = false;
            return 20; 
        }
    }
}