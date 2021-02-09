namespace TarotCardGame.Library.Models
{
	public enum Suit
	{
		HEART,
		SPADE,
		DIAMOND,
		CLUB
	}

	public static class SuitExtensions
	{
		public static string GetString(this Suit suit)
		{
			switch (suit)
			{
				case Suit.HEART:
					return "Heart";
				case Suit.SPADE:
					return "Spade";
				case Suit.DIAMOND:
					return "Diamond";
				case Suit.CLUB:
					return "Club";
				default:
					return null;
			}
		}
	}
}