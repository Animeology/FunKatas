namespace FunKatas.Katas.BowlingGame
{
    using FunKatas.KataTest.BowlingGameTests;

    public class BowlingGame
    {
        int Attempts;
        int LeftoverPins = TOTAL_PINS;
        int KnockedDownPins;
        public int Score;
        public int MockKnockedPins;

        bool IsTesting = false;

        public void Bowling()
        {
            if(IsTesting)
            {
                TestChecker();
            }
            LoopRolls();
            DisplayScore();
        }

        void TestChecker()
        {
            BowlingGameTests tests = new BowlingGameTests();
            tests.HitNoPins_ReturnsZero();
            tests.HitFivePins_ReturnFive();
        }

        public void BowlingAttempt()
        {
            if (LeftoverPins == EMPTY_FRAME)
            {
                LeftoverPins = TOTAL_PINS;
                KnockedDownPins = 0;
                Attempts = 0;
                Console.WriteLine("No more pins, Resetting frame");
            }

            Random random = new Random();
            KnockedDownPins = random.Next(EMPTY_FRAME, Math.Min(LeftoverPins, TOTAL_PINS) + 1);

            if (IsTesting)
            {
                KnockedDownPins = MockKnockedPins;
            }

            LeftoverPins -= KnockedDownPins;
            Attempts++;

            Score += KnockedDownPins;

            CheckerForCertainRolls();
        }

        void LoopRolls()
        {
            for (int i = 1; i <= TOTAL_FRAMES; i++)
            {
                BowlingAttempt();
                Console.WriteLine($"Frame {i}: Knocked Pins: {KnockedDownPins} Pins Left: {LeftoverPins} Attempt: {Attempts}");
            }
        }

        void CheckerForCertainRolls()
        {
            if (IsStrike())
            {
                Console.WriteLine("It's a STRIKE!!!");
            }
            else if (IsSpare())
            {
                Console.WriteLine("Spare");
            }
        }

        bool IsSpare()
        {
            if (Attempts == 2 && KnockedDownPins == TOTAL_PINS)
            {
                return true;
            }
            return false;
        }

        bool IsStrike()
        {
            if (Attempts == 1 && KnockedDownPins == TOTAL_PINS)
            {
                return true;
            }
            return false;
        }

        void DisplayScore()
        {
            Console.WriteLine($"Score: {Score}");
        }

        const int EMPTY_FRAME = 0;
        const int TOTAL_PINS = 10;
        const int TOTAL_FRAMES = 10;
    }
}
