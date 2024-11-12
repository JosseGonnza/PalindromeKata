using FluentAssertions;

namespace PalindromeKata;

public class PalindromeShould
{
    [Fact(DisplayName = "be false when contains less than 2 characters")]
    public void be_false_when_contains_less_than_2_characters()
    {
        var palindromo = "a";

        var result = IsPalindrome(palindromo);

        result.Should().BeFalse();
    }

    private static bool IsPalindrome(string palindromo)
    {
        return true;
    }
}