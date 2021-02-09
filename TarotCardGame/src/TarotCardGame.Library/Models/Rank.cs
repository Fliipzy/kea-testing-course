namespace TarotCardGame.Library.Models
{
	public enum Rank
	{
		ACE,
		TWO,
		THREE,
		FOUR,
		FIVE,
		SIX,
		SEVEN,
		EIGHT,
		NINE,
		TEN,
		JACK,
		KNIGHT,
		QUEEN,
		KING
	}
	
	public static class RankExtensions
	{
		public static string GetString(this Rank rank)
		{
			switch (rank)
			{
				case Rank.ACE:
					return "Ace";
				case Rank.TWO:
					return "Two";
				case Rank.THREE:
					return "Three";
				case Rank.FOUR:
					return "Four";
				case Rank.FIVE:
					return "Five";
				case Rank.SIX:
					return "Six";
				case Rank.SEVEN:
					return "Seven";
				case Rank.EIGHT:
					return "Eight";
				case Rank.NINE:
					return "Nine";
				case Rank.TEN:
					return "Ten";
				case Rank.JACK:
					return "Jack";
				case Rank.KNIGHT:
					return "Knight";
				case Rank.QUEEN:
					return "Queen";
				case Rank.KING:
					return "King";
				default:
					return null;
			}
		}
	}
}