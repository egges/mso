using System;

namespace Lab3
{
	public static class PricingTable
	{
		public static float getPrice(int tariefeenheden, int col)
		{
            double price = 0;

			switch (col) {
			case 0:
				price = 2.10;
                break;
			case 1:
				price = 1.70;
                break;
			case 2:
                price = 1.30;
                break;
			case 3:
                price = 3.60;
                break;
			case 4:
                price = 2.90;
                break;
			case 5:
                price = 2.20;
                break;
			default:
				throw new Exception ("Unknown column number");
			}

            price = price * 0.02 * tariefeenheden;

            return (float)Math.Round(price, 2);
		}
	}
}

