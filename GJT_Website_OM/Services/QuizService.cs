using GJT_Website_OM.Models;
using Microsoft.EntityFrameworkCore;


namespace GJT_Website_OM.Services
{
    public class QuizService
    {
        private readonly TlS2303831GjtContext _context;

        public QuizService(TlS2303831GjtContext context)
        {
            _context = context;
        }
        public async Task<List<Quiz>> GetQuizzes(int difficulty, string subject)
        {
            return await _context.Quizzes.Where(q => q.Difficuilty == difficulty && q.Subject == subject).ToListAsync();
        }

        public async Task<List<Question>> GetQuestions(int QuizId)
        {
            return await _context.Questions.Where(q => q.QuizId == QuizId).ToListAsync();
        }
      
    }
}

//on your page
//let user select subject and difficulty
//search for quizzes using getQuizzes

//let user pick quiz
//use that quizId to search for questions using getQuestions