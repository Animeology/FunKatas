namespace FunKatas.KataTest.BowlingGameTests
{
    using FunKatas.Katas.BowlingGame;

    public class BowlingGameTests
    {
        public void HitNoPins_ReturnsZero()
        {
            BowlingGame game = new BowlingGame();

            game.KnockedDownPins = 0;

            game.BowlingAttempt();

            if(game.Score != 0)
            {
                throw new Exception("Zero Pins doesn't return 0");
            }
        }
    }
}
