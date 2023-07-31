namespace FunKatas.Katas
{
    public class CheckoutKata
    {
        int itemA = 50;
        int itemB = 30;
        int itemC = 20;
        int itemD = 15;

        int itemACount = 0;
        int itemBCount = 0;
        int itemCCount = 0;
        int itemDCount = 0;

        public void Checkout()
        {
            Menu();
            Selection();
        }

        void Selection()
        {
            int choice = -1;
            do
            {
                Console.WriteLine("Select your items");
                Console.WriteLine("1 for A");
                Console.WriteLine("2 for B");
                Console.WriteLine("3 for C");
                Console.WriteLine("4 for D");
                Console.WriteLine("0 to Quit");

                choice = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        itemACount++;
                        Menu();
                        ShoppingCart();
                        break;
                    case 2:
                        itemBCount++;
                        Menu();
                        ShoppingCart();
                        break;
                    case 3:
                        itemCCount++;
                        Menu();
                        ShoppingCart();
                        break;
                    case 4:
                        itemDCount++;
                        Menu();
                        ShoppingCart();
                        break;
                    case 0:
                        ShoppingCart();
                        Console.Write("Total: ");
                        Console.WriteLine(CalculateTotal (
                            itemACount,
                            itemBCount, 
                            itemCCount, 
                            itemDCount
                            )
                        );
                        break;
                    default:
                        Console.WriteLine("Not a valid item");
                        break;
                }

            } while (choice != 0);
        }

        void Menu()
        {
            Console.Write("A: ");
            Console.Write("50");
            Console.WriteLine(" Discount Offer: 3 for 130");

            Console.Write("B: ");
            Console.Write("30");
            Console.WriteLine(" Discount Offer: 2 for 45");

            Console.Write("C: ");
            Console.WriteLine("20");

            Console.Write("D: ");
            Console.WriteLine("15");

            Console.WriteLine();
        }


        int CalculateTotal(int a, int b, int c, int d)
        {
            int total;

            total = (itemA * a) + (itemB * b) + (itemC * c) + (itemD * d);

            if((a % OFFER_ITEM_A) == 0)
            {
                total -= ITEM_A_DISCOUNT;
            }
            else if((b % OFFER_ITEM_B) == 0)
            {
                total -= ITEM_B_DISCOUNT;
            }

            return total;
        }

        void ShoppingCart()
        {
            Console.WriteLine("Current Cart:");
            Console.WriteLine($"A: {itemACount}");
            Console.WriteLine($"B: {itemBCount}");
            Console.WriteLine($"C: {itemCCount}");
            Console.WriteLine($"D: {itemDCount}");
            Console.WriteLine();
        }

        const int OFFER_ITEM_A = 3;
        const int OFFER_ITEM_B = 2;

        const int ITEM_A_DISCOUNT = 20;
        const int ITEM_B_DISCOUNT = 15;
    }
}
