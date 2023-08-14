namespace FunKatas.KataTest.BowlingGameTests
{
    using Katas.BowlingGame;

    public class BowlingGameTests
    {
        public void HitNoPins_ReturnsZero()
        {
            BowlingGame game = new BowlingGame();

            game.MockKnockedPins = 0;

            game.BowlingAttempt();

            if(game.Score != 0)
            {
                throw new Exception("Zero Pins doesn't return 0");
            }
        }

        public void HitFivePins_ReturnFive()
        {
            BowlingGame game = new BowlingGame();

            game.MockKnockedPins = 5;

            game.BowlingAttempt();

            if (game.Score != 5)
            {
                throw new Exception("Five Pins doesn't return 5");
            }
        }

        public void HitTenPins_ReturnTen()
        {
            BowlingGame game = new BowlingGame();

            game.MockKnockedPins = 10;

            game.BowlingAttempt();

            if (game.Score != 10)
            {
                throw new Exception("Ten Pins doesn't return 10");
            }
        }
    }
}
