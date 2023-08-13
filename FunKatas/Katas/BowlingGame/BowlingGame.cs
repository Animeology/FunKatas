﻿namespace FunKatas.Katas.BowlingGame
{
    public class BowlingGame
    {
        int Attempts;
        int LeftoverPins = TOTAL_PINS;
        public int KnockedDownPins;
        public int Score;

        public void Bowling()
        {
            BowlingAttempts();
            DisplayScore();
        }

        public void BowlingAttempts()
        {
            for (int i = 1; i <= TOTAL_FRAMES; i++)
            {
                if (LeftoverPins == EMPTY_FRAME)
                {
                    LeftoverPins = TOTAL_PINS;
                    KnockedDownPins = 0;
                    Attempts = 0;
                    //Console.WriteLine("No more pins, Resetting frame");
                }

                Random random = new Random();
                KnockedDownPins = random.Next(EMPTY_FRAME, Math.Min(LeftoverPins, TOTAL_PINS) + 1);

                LeftoverPins -= KnockedDownPins;
                Attempts++;

                Score += KnockedDownPins;

                Console.WriteLine($"Frame {i}: Knocked Pins: {KnockedDownPins} Pins Left: {LeftoverPins} Attempt: {Attempts}");
                CheckerForCertainRolls();
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
