namespace SpaceDefender.Core
{
    public class ScoreCalculator
    {
        public int Multiplier { get; private set; } = 1;

        public int Calculate(int kills, int basePoints) => kills * basePoints * Multiplier;

        public void ApplyCombo(int killStreak)
        {
            if (killStreak >= 3) Multiplier = 2;
        }

        public void ResetMultiplier() => Multiplier = 1; 
    }
}