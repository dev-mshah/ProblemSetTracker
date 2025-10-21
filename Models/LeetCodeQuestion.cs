namespace LeetCode.Models
{
    public class LeetCodeQuestion
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Difficulty { get; set; } = string.Empty; // Easy, Medium, Hard
        public string Link { get; set; } = string.Empty;       // Solved, Unsolved, In Progress
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;

        // ✅ New property for filtering
        public string Category { get; set; } = string.Empty;
    }
}
