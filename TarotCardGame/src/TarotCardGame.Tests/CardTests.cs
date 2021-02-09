using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TarotCardGame.Library.Models;

namespace TarotCardGame.Tests
{
    [TestClass]
    public class CardTests
    {

        [DataTestMethod]
        [DynamicData(nameof(CardTests.GetData), DynamicDataSourceType.Method)]
        public void Card_ToString_Method_Retuns_Correct_Result(Card card)
        {
            StringAssert.Matches(card.ToString(), new Regex($"{card.Rank.GetString()} of {card.Suit.GetString()}"));
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new Card(Suit.CLUB, Rank.SEVEN) };
            yield return new object[] { new Card(Suit.HEART, Rank.KING) };
            yield return new object[] { new Card(Suit.DIAMOND, Rank.QUEEN) };
            yield return new object[] { new Card(Suit.CLUB, Rank.ACE) };
            yield return new object[] { new Card(Suit.SPADE, Rank.THREE) };
        }
    }
}
