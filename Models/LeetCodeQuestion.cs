namespace LeetCode.Models
{
    public class LeetCodeQuestion
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Difficulty { get; set; } = string.Empty; // Easy, Medium, Hard
        public string Status { get; set; } = "Unsolved";       // Solved, Unsolved, In Progress
        public string Notes { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    }
}
