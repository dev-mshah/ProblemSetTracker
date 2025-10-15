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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeetCodeQuestion>>> GetQuestions()
        {
            return await _context.LeetCodeQuestions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LeetCodeQuestion>> GetQuestion(int id)
        {
            var question = await _context.LeetCodeQuestions.FindAsync(id);
            return question == null ? NotFound() : question;
        }

    }
}
