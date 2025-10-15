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
                        Status = "Solved",
                        Notes = "Used a hashmap to store complements."
                    },
                    new LeetCodeQuestion
                    {
                        Title = "Valid Parentheses",
                        Difficulty = "Easy",
                        Status = "Solved",
                        Notes = "Stack-based approach."
                    },
                    new LeetCodeQuestion
                    {
                        Title = "Merge Intervals",
                        Difficulty = "Medium",
                        Status = "Unsolved",
                        Notes = "Need to review sorting by start time."
                    },
                    new LeetCodeQuestion
                    {
                        Title = "Median of Two Sorted Arrays",
                        Difficulty = "Hard",
                        Status = "Unsolved",
                        Notes = "Binary search on partitions."
                    }
                };

                context.LeetCodeQuestions.AddRange(questions);
                context.SaveChanges();
            }
        }
    }
}
