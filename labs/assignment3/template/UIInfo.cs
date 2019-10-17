using System;

namespace Lab3
{
	public enum UIClass
	{
		FirstClass,
		SecondClass
	}

	public enum UIWay
	{
		OneWay,
		Return
	}

	public enum UIDiscount
	{
		NoDiscount,
		TwentyDiscount,
		FortyDiscount
	}

	public enum UIPayment
	{
		DebitCard,
		CreditCard,
		Cash
	}

	public struct UIInfo
	{
		string from, to;
		UIClass cls;
		UIWay way;
		UIDiscount discount;
		UIPayment payment;

		public UIInfo (string from, string to, UIClass cls, UIWay way, UIDiscount discount, UIPayment payment)
		{
			this.from = from;
			this.to = to;
			this.cls = cls;
			this.way = way;
			this.discount = discount;
			this.payment = payment;
		}

		public string From {
			get {
				return from;
			}
		}

		public string To {
			get {
				return to;
			}
		}

		public UIClass Class {
			get {
				return cls;
			}
		}

		public UIWay Way {
			get {
				return way;
			}
		}

		public UIDiscount Discount {
			get {
				return discount;
			}
		}

		public UIPayment Payment {
			get {
				return payment;
			}
		}
	}
}

