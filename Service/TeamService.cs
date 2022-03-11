namespace network;
public class TeamService : ITeamService
{
    private readonly ITeamRepository _TeamRepository;

    public TeamService(ITeamRepository teamRepository)
    {
        _TeamRepository = teamRepository;
    }

    public async Task<Team> CreateTeam(Team team)
    {
     return await _TeamRepository.CreateTeam(team);   
    }

    public async Task DeleteTeam(Team team)
    {
     await _TeamRepository.DeleteTeam(team);   
    }

    public async Task<List<Category>> GetAllCategory()
    {
        return await _TeamRepository.GetAllCategory();
    }

    public async Task<List<Team>> GetAllTeam()
    {
        return await _TeamRepository.GetAllTeam();
    }

    public async Task<Category> GetCategory(int Id)
    {
        return await _TeamRepository.GetCategory(Id);
    }

    public async Task<Team> GetTeam(int Id)
    {
       return await _TeamRepository.GetTeam(Id);
    }
}