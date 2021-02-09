namespace TarotCardGame.Library.Models
{
	public sealed class Card
	{
		public Suit Suit { get; private set; }
		public Rank Rank { get; private set; }

		public Card(Suit suit, Rank rank)
		{
			Suit = suit;
			Rank = rank;
		}

		public override string ToString()
		{
			return $"{Rank.GetString()} of {Suit.GetString()}";
		}
	}
}