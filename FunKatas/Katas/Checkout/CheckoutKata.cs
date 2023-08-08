namespace FunKatas.Katas.Checkout
{
    public class CheckoutKata
    {
        public int Total { get; private set; }

        int itemACount;
        int itemBCount;
        int itemCCount;
        int itemDCount;

        Dictionary<char, int> prices = new Dictionary<char, int> { { 'A', 50 }, { 'B', 30 }, { 'C', 20 }, { 'D', 15 } };
        Dictionary<char, int> itemCount = new Dictionary<char, int> { { 'A', 0 }, { 'B', 0 }, { 'C', 0 }, { 'D', 0 } };
        Dictionary<char, Offer> offers = new Dictionary<char, Offer>
        {
            {'A', new Offer{Discount = ITEM_A_DISCOUNT, NumberOfItems = OFFER_ITEM_A} },
            {'B', new Offer{Discount = ITEM_B_DISCOUNT, NumberOfItems = OFFER_ITEM_B } }
        };

        public void Checkout()
        {
            Menu();
            Selection();
        }

        void Scan(char item)
        {
            itemCount[item]++;
            Total += prices[item];

            if (IsOffer(item) && OfferNumber(item))
            {
                Total -= offers[item].Discount;
            }
        }

        bool IsOffer(char item)
        {
            return offers.ContainsKey(item);
        }

        bool OfferNumber(char item)
        {
            return itemCount[item] == offers[item].NumberOfItems;
        }

        void Selection()
        {
            char choice = ' ';
            do
            {
                Console.WriteLine("Select your items");
                Console.WriteLine("A");
                Console.WriteLine("B");
                Console.WriteLine("C");
                Console.WriteLine("D");
                Console.WriteLine("0 to Quit");

                choice = char.Parse(Console.ReadLine()!);
                Console.WriteLine();

                switch (Char.ToUpper(choice))
                {
                    case 'A':
                        itemACount++;
                        Menu();
                        Scan('A');
                        ShoppingCart();
                        break;
                    case 'B':
                        itemBCount++;
                        Menu();
                        Scan('B');
                        ShoppingCart();
                        break;
                    case 'C':
                        itemCCount++;
                        Menu();
                        Scan('C');
                        ShoppingCart();
                        break;
                    case 'D':
                        itemDCount++;
                        Menu();
                        Scan('D');
                        ShoppingCart();
                        break;
                    case '0':
                        ShoppingCart();
                        Console.WriteLine($"Total: {Total}");
                        break;
                    default:
                        Console.WriteLine("Not a valid item");
                        break;
                }

            } while (choice != '0');
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
