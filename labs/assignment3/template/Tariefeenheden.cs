using System;

namespace Lab3
{
	public static class Tariefeenheden
	{
		public static String[] getStations()
		{
			return new String[] {
				"Utrecht Centraal",
				"Gouda",
				"Geldermalsen",
				"Hilversum",
				"Duivendrecht",
				"Weesp"
			};
		}

		public static int getTariefeenheden(String from, String to) 
		{
			switch (from) {
			case "Utrecht Centraal":
				switch (to) {
				case "Utrecht Centraal":
					return 0;
				case "Gouda":
					return 32;
				case "Geldermalsen":
					return 26;
				case "Hilversum":
					return 18;
				case "Duivendrecht":
					return 31;
				case "Weesp":
					return 33;
				default:
					throw new Exception ("Unknown stations");
				}
			case "Gouda":
				switch (to) {
				case "Gouda":
					return 0;
				case "Geldermalsen":
					return 58;
				case "Hilversum":
					return 50;
				case "Duivendrecht":
					return 54;
				case "Weesp":
					return 57;
				default:
					return getTariefeenheden (to, from);
				}
			case "Geldermalsen":
				switch (to) {
				case "Geldermalsen":
					return 0;
				case "Hilversum":
					return 44;
				case "Duivendrecht":
					return 57;
				case "Weesp":
					return 59;
				default:
					return getTariefeenheden (to, from);
				}
			case "Hilversum":
				switch (to) {
				case "Hilversum":
					return 0;
				case "Duivendrecht":
					return 18;
				case "Weesp":
					return 15;
				default:
					return getTariefeenheden (to, from);
				}
			case "Duivendrecht":
				switch (to) {
				case "Duivendrecht":
					return 0;
				case "Weesp":
					return 3;
				default:
					return getTariefeenheden (to, from);
				}
			case "Weesp":
				switch (to) {
				case "Weesp":
					return 0;
				default:
					return getTariefeenheden (to, from);
				}
			default:
				throw new Exception ("Unknown stations");
			}
		}
	}
}

