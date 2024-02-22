namespace LongestIncreasingSubsequence;

/// <summary>
/// Utility methods to search for sequencies in strings 
/// </summary>
public static class SequenceHunter
{
    /// <summary>
    /// Finds the longest increasing continuous subsequence
    /// </summary>
    /// <param name="input">A string of any number of integers separated by single whitespace</param>
    /// <returns>The longest increasing continuous subsequence</returns>
    /// <note>
    /// The question does not explicitly require the subsequence to be continuous
    /// but the provided test cases imply that the subsequence should be continuous.
    /// Given the test cases the classical dynamic algorithms for Longest Increasing Subsequence (LIS)
    /// will not solve this problem.
    /// 
    /// This method employs a linear scan approach which iterates through the sequence of numbers 
    /// and keeps track of the current increasing subsequence. When we find that the current number is not greater than the previous one, we compare the length of the current increasing subsequence to the longest one found so far and update accordingly. This approach ensures that  we find the earliest longest increasing continuous subsequence in case there are multiple subsequences of the longest length.
    /// </note>
    public static string FindLongestIncreasingSubsequence(string input)
    {

        // Array to store integers from the input string 
        int[] numbers;

        // Parse the input string into an array of integers
        // parsing will fail if the input string contains non integer elements       
        try
        {
            numbers = input.Split(' ')
            .Select(int.Parse)
            .ToArray();
        }

        // Catching the specific format exception for parsing
        catch (FormatException ex)
        {
            // Throw a more detailed exception if parsing fails
            throw new ArgumentException("Input string should only contain integers separated by a single whitespace.", ex);

        }

        int maxLength = 1;
        int currentLength = 1;

        int startIndex = 0;
        int tempStartIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            // Check if the current number continues the increasing sequence
            if (numbers[i] > numbers[i - 1])
            {
                currentLength++;
                // Update the longest sequence if necessary
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    startIndex = tempStartIndex;
                }
            }
            else
            {
                // Reset for the next sequence
                currentLength = 1;
                tempStartIndex = i;
            }
        }

        // Extract the longest increasing continuous subsequence
        int[] longestSubsequence = new int[maxLength];
        Array.Copy(numbers, startIndex, longestSubsequence, 0, maxLength);

        // Convert the result to a string
        return string.Join(" ", longestSubsequence);

    }

}
