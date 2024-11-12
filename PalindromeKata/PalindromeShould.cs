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
    
    [Fact(DisplayName = "be false when word is not a palindrome")]
    public void be_false_when_word_is_not_a_palindrome()
    {
        var palindromo = "nopalindrome";

        var result = IsPalindrome(palindromo);

        result.Should().BeFalse();
    }
    
    [Theory(DisplayName = "be true when word is a palindrome")]
    [InlineData("ana")]
    [InlineData("oro")]
    [InlineData("reconocer")]
    public void be_true_when_word_is_a_palindrome(string palindrome)
    {
        var result = IsPalindrome(palindrome);

        result.Should().BeTrue();
    }


    private static bool IsPalindrome(string palindromo)
    {
        var reverse = "";
        for (int i = (palindromo.ToCharArray().Length - 1); i >= 0; i--)
        {
            reverse += palindromo[i];
        }
        if (palindromo.Length >= 2 && reverse == palindromo)
        {
            return true;
        }
        return false;
    }
}