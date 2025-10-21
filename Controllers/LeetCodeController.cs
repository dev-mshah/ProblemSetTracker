using Microsoft.AspNetCore.Mvc;
using LeetCode.Data;
using LeetCode.Models;
using Microsoft.EntityFrameworkCore;

namespace LeetCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeetCodeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LeetCodeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/leetcode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeetCodeQuestion>>> GetQuestions()
        {
            return await _context.LeetCodeQuestions.ToListAsync();
        }

        // GET: api/leetcode/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeetCodeQuestion>> GetQuestion(int id)
        {
            var question = await _context.LeetCodeQuestions.FindAsync(id);
            return question == null ? NotFound() : question;
        }

        // ✅ POST: api/leetcode
        [HttpPost]
        public async Task<ActionResult<LeetCodeQuestion>> PostQuestion(LeetCodeQuestion question)
        {
            question.DateAdded = DateTime.UtcNow;
            _context.LeetCodeQuestions.Add(question);
            await _context.SaveChangesAsync();

            // Returns 201 Created with location header
            return CreatedAtAction(nameof(GetQuestion), new { id = question.Id }, question);
        }
    }
}
