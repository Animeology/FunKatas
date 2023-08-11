namespace FunKatas.Katas.BowlingGame
{
    public class BowlingGame
    {
        int Attempts;

        int KnockedDownPins;

        public void Bowling()
        {
            FrameAttempts();
        }

        bool IsSpare()
        {
            return Attempts == 2 && KnockedDownPins == TOTAL_PINS ? true : false;
        }

        bool IsStrike()
        {
            return Attempts == 1 && KnockedDownPins == TOTAL_PINS ? true : false;
        }

        void FrameAttempts()
        {
            for(int i = 1; i <= TOTAL_FRAMES; i++)
            {                
                Random random = new Random();
                KnockedDownPins = random.Next(EMPTY_FRAME, TOTAL_PINS);
                int leftoverPins = 10;

                leftoverPins -= KnockedDownPins;
                Attempts++;

                if (KnockedDownPins == TOTAL_PINS)
                {
                    KnockedDownPins = 0;
                    leftoverPins = 10;
                    Attempts = 0;
                }

                if (IsSpare())
                {
                    Console.WriteLine("Spare");
                }

                if(IsStrike())
                {
                    Console.WriteLine("It's a STRIKE!!!");
                }

                Console.WriteLine($"Frame {i}: Knocked Pins: {KnockedDownPins} Pins Left: {leftoverPins}");
            }
        }

        const int EMPTY_FRAME = 0;

        const int TOTAL_PINS = 10;        

        const int TOTAL_FRAMES = 10;
    }
}
