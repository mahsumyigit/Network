using Enum;
using static network.Category;

namespace network
{
    public interface ITeamRepository
    {
      Task<List<Team>> GetAllTeam();
      Task<List<Category>> GetAllCategory();
    Task<Team> GetTeam(int Id);
    Task<Category> GetCategory(int Id);
    Task<Team> DeleteTeam(Team team);
    Task<Team> CreateTeam(Team team);
    }
}