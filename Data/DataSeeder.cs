using LeetCode.Models;

namespace LeetCode.Data
{
    public static class DataSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.LeetCodeQuestions.Any())
            {
                var questions = new List<LeetCodeQuestion>
                {
                    new LeetCodeQuestion
                    {
                        Title = "Two Sum",
                        Difficulty = "Easy",
                        Link = "https://leetcode.com/problems/two-sum/",
                        Category = "Array"
                    },
                    new LeetCodeQuestion
                    {
                        Title = "Valid Parentheses",
                        Difficulty = "Easy",
                        Link = "https://leetcode.com/problems/valid-parentheses/",
                        Category = "Stack"
                    },
                    new LeetCodeQuestion
                    {
                        Title = "Merge Intervals",
                        Difficulty = "Medium",
                        Link = "https://leetcode.com/problems/merge-intervals/",
                        Category = "Interval"
                    },
                    new LeetCodeQuestion
                    {
                        Title = "Median of Two Sorted Arrays",
                        Difficulty = "Hard",
                        Link = "https://leetcode.com/problems/median-of-two-sorted-arrays/",
                        Category = "Binary Search"
                    }
                };

                context.LeetCodeQuestions.AddRange(questions);
                context.SaveChanges();
            }
        }
    }
}
