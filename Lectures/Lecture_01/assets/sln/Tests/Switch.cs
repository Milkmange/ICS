﻿using Xunit;

namespace Tests
{
    public class Switch
    {
        private string Foo(int cardNumber)
        {
            string result = string.Empty;

            switch (cardNumber)
            {
                case 10:
                case 13:
                    result = "King";
                    break;
                case 12:
                    result = "Queen";
                    break;
                case 11:
                    result = "Jack";
                    break;
                case -1:                          // Joker is −1
                    goto case 12;                 // In this game joker counts as queen
                default:                          // Executes for any other cardNumber
                    result = cardNumber.ToString();
                    break;
            }

            return result;
        }

        [Fact]
        public void Test()
        {
            Assert.Equal("1", Foo(1));
            Assert.Equal("King", Foo(10));
            Assert.Equal("King", Foo(13));
            Assert.Equal("Queen", Foo(12));
            Assert.Equal("Queen", Foo(-1));
        }

        private string SwitchExpression(int cardNumber) =>
            cardNumber switch
            {
                10 => "King",
                13 => "King",
                -1 => "Queen",
                12 => "Queen",
                11 => "Jack",
                _ => cardNumber.ToString()
            };

        [Fact]
        public void TestSwitchExpression()
        {
            Assert.Equal("1", SwitchExpression(1));
            Assert.Equal("King", SwitchExpression(10));
            Assert.Equal("King", SwitchExpression(13));
            Assert.Equal("Queen", SwitchExpression(12));
            Assert.Equal("Queen", SwitchExpression(-1));
        }
    }
}