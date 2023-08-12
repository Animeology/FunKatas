namespace FunKatas.Katas.BowlingGame
{
    public class BowlingGame
    {
        int Attempts;
        int KnockedDownPins;
        int LeftoverPins = TOTAL_PINS;
        int Score;

        public void Bowling()
        {
            BowlingAttempts();
        }

        bool IsSpare()
        {
            return Attempts == 2 && KnockedDownPins == TOTAL_PINS ? true : false;
        }

        bool IsStrike()
        {
            return Attempts == 1 && KnockedDownPins == TOTAL_PINS ? true : false;
        }

        void BowlingAttempts()
        {
            for (int i = 1; i <= TOTAL_FRAMES; i++)
            {
                Random random = new Random();
                KnockedDownPins = random.Next(EMPTY_FRAME, Math.Min(LeftoverPins, TOTAL_PINS));

                LeftoverPins = LeftoverPins - KnockedDownPins;
                Attempts++;

                if (LeftoverPins == EMPTY_FRAME)
                {
                    LeftoverPins = TOTAL_PINS;
                    Attempts = 0;
                    Console.WriteLine("No more pins");
                }

                if (IsStrike())
                {
                    Console.WriteLine("It's a STRIKE!!!");
                }
                else if (IsSpare())
                {
                    Console.WriteLine("Spare");
                }

                Console.WriteLine($"Frame {i}: Knocked Pins: {KnockedDownPins} Pins Left: {LeftoverPins}");
            }
        }

        const int EMPTY_FRAME = 0;
        const int TOTAL_PINS = 10;
        const int TOTAL_FRAMES = 10;
    }
}
