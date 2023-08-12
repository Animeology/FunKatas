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
            DisplayScore();
        }


        void BowlingAttempts()
        {
            for (int i = 1; i <= TOTAL_FRAMES; i++)
            {
                Random random = new Random();
                KnockedDownPins = random.Next(EMPTY_FRAME, Math.Min(LeftoverPins, TOTAL_PINS) + 1);

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
                    if(Attempts == 2)
                    {
                        Score += KnockedDownPins;
                    }
                }
                else if (IsSpare())
                {
                    Console.WriteLine("Spare");
                    if (Attempts == 3)
                    {
                        Score += KnockedDownPins;
                    }
                }

                Score += KnockedDownPins;

                Console.WriteLine($"Frame {i}: Knocked Pins: {KnockedDownPins} Pins Left: {LeftoverPins}");
            }
        }
        bool IsSpare()
        {
            if(Attempts == 2 && KnockedDownPins == TOTAL_PINS)
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
