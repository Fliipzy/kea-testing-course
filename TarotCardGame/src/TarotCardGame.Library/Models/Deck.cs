using System.Collections.Generic;

namespace TarotCardGame.Library.Models
{
	public sealed class Deck
	{
		public ICollection<Card> Cards { get; private set; }
	}
}