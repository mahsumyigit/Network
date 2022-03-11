using Enum;
using Microsoft.EntityFrameworkCore;

namespace network
{
    public class TeamRepository : ITeamRepository
    {
        private readonly NetworkDbContext _context;

        public TeamRepository(NetworkDbContext context)
        {
            _context = context;
        }

        public async Task<Team> CreateTeam(Team team)
        {
            await _context.Teams.AddAsync(team);
            await _context.SaveChangesAsync();
            return team;
        }

        public async Task DeleteTeam(Team team)
        {
            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetAllCategory()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<List<Team>> GetAllTeam()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Category> GetCategory(int Id)
        {
            return await _context.Categories.FirstOrDefaultAsync(p=>p.Id==Id);
        }

        public async Task<Team> GetTeam(int Id)
        {
            return await _context.Teams.FirstOrDefaultAsync(p=>p.Id==Id);
        }
    }
}
