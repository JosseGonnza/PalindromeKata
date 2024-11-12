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
    
    [Fact(DisplayName = "be true when contains more than 2 characters")]
    public void be_true_when_contains_more_than_2_characters()
    {
        var palindromo = "aa";

        var result = IsPalindrome(palindromo);

        result.Should().BeTrue();
    }

    private static bool IsPalindrome(string palindromo)
    {
        return false;
    }
}