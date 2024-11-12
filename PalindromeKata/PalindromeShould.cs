using FluentAssertions;

namespace PalindromeKata;

public class PalindromeShould
{
    [Fact(DisplayName = "be false when contains less than 2 characters")]
    public void be_false_when_contains_less_than_2_characters()
    {
        var result = IsPalindrome("a");

        result.Should().BeFalse();
    }
    
    [Fact(DisplayName = "be true when contains more than 2 characters")]
    public void be_true_when_contains_more_than_2_characters()
    {
        var result = IsPalindrome("aa");

        result.Should().BeTrue();
    }
    
    [Fact(DisplayName = "be false when word is not a palindrome")]
    public void be_false_when_word_is_not_a_palindrome()
    {
        var result = IsPalindrome("nopalindrome");

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
    
    [Theory(DisplayName = "be ignore upper and lower case letter")]
    [InlineData("Ana")]
    [InlineData("Oro")]
    [InlineData("Reconocer")]
    public void be_ignore_upper_and_lower_case_letter(string palindrome)
    {
        var result = IsPalindrome(palindrome);

        result.Should().BeTrue();
    }
    
    private static bool IsPalindrome(string palindromo)
    {
        var reverse = "";
        var lowerPalindrome = palindromo.ToLower();
        for (int i = (lowerPalindrome.ToCharArray().Length - 1); i >= 0; i--)
        {
            reverse += lowerPalindrome[i];
        }
        return palindromo.Length >= 2 && reverse == lowerPalindrome;
    }
}