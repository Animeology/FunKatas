namespace FunKatas.KataTest.CheckoutTests
{
    using Katas.Checkout;    

    public class CheckoutTests
    {
        public void NoItemsScanned_ReturnsZero()
        {
            CheckoutKata checkout = new CheckoutKata();

            if(checkout.Total != 0)
            {
                throw new Exception("NoItems_Scanned_ReturnsZero");
            }
        }

        public void ItemAScanned_ReturnItemAPrice()
        {
            CheckoutKata checkout = new CheckoutKata();

            char itemA = 'A';

            int itemATotal = 50;

            checkout.Scan(itemA);
            if(checkout.Total != itemATotal)
            {
                throw new Exception("Item A is not priced correctly");
            }
        }

        public void ItemBScanned_ReturnItemBPrice()
        {
            CheckoutKata checkout = new CheckoutKata();

            char itemB = 'B';

            int itemBTotal = 30;

            checkout.Scan(itemB);
            if (checkout.Total != itemBTotal)
            {
                throw new Exception("Item B is not priced correctly");
            }
        }

        public void ItemCScanned_ReturnItemCPrice()
        {
            CheckoutKata checkout = new CheckoutKata();

            char itemC = 'C';

            int itemCTotal = 20;

            checkout.Scan(itemC);
            if (checkout.Total != itemCTotal)
            {
                throw new Exception("Item C is not priced correctly");
            }
        }

        public void ItemDScanned_ReturnItemDPrice()
        {
            CheckoutKata checkout = new CheckoutKata();

            char itemD = 'D';

            int itemDTotal = 15;

            checkout.Scan(itemD);
            if (checkout.Total != itemDTotal)
            {
                throw new Exception("Item D is not priced correctly");
            }
        }

        public void MultipleItemsScanned_ReturnCorrectPrice()
        {
            CheckoutKata checkout = new CheckoutKata();

            char itemA = 'A';
            char itemD = 'D';

            int total = 65;

            checkout.Scan(itemA);
            checkout.Scan(itemD);
            if (checkout.Total != total)
            {
                throw new Exception("Total is not correct");
            }
        }

        public void ItemADiscount_ReturnsCorrectDiscountPrice()
        {
            CheckoutKata checkout = new CheckoutKata();

            char itemA = 'A';

            int total = 130;

            checkout.Scan(itemA);
            checkout.Scan(itemA);
            checkout.Scan(itemA);

            if(checkout.Total != total)
            {
                throw new Exception("Discount for Item A is incorrect");
            }
        }

        public void ItemBDiscount_ReturnsCorrectDiscountPrice()
        {
            CheckoutKata checkout = new CheckoutKata();

            char itemB = 'B';

            int total = 45;

            checkout.Scan(itemB);
            checkout.Scan(itemB);            

            if (checkout.Total != total)
            {
                throw new Exception("Discount for Item B is incorrect");
            }
        }


        public void ItemCDiscount_ReturnsCorrectDiscountPrice()
        {
            CheckoutKata checkout = new CheckoutKata();

            char itemC = 'C';

            int total = 65;

            checkout.Scan(itemC);
            checkout.Scan(itemC);
            checkout.Scan(itemC);
            checkout.Scan(itemC);

            if (checkout.Total != total)
            {
                throw new Exception("Discount for Item C is incorrect");
            }
        }


        public void ItemDDiscount_ReturnsCorrectDiscountPrice()
        {
            CheckoutKata checkout = new CheckoutKata();

            char itemD = 'D';

            int total = 35;

            checkout.Scan(itemD);
            checkout.Scan(itemD);
            checkout.Scan(itemD);

            if (checkout.Total != total)
            {
                throw new Exception("Discount for Item D is incorrect");
            }
        }


    }
}
