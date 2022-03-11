using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using network.Models;

namespace network
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _TeamService;

        public TeamController(ITeamService teamService)
        {
            _TeamService = teamService;
        }
        [HttpPost("Create")]
        public async Task<Team> Create(Team team)
        {
            await _TeamService.CreateTeam(team);
            return team;
        }
        [HttpPut("delete")]
        public async Task TaskDelete(Team team)
        {
            await _TeamService.DeleteTeam(team);
        }
        [HttpGet("GetAllTeam")]
        public async Task<List<Team>> GetTeams()
        {

            return await _TeamService.GetAllTeam();
        }
        [HttpGet("GetAll")]
        public async Task<List<Category>> GetCategories()
        {

            return await _TeamService.GetAllCategory();
        }
        [HttpGet("GetTeamId")]
        public async Task<Team> GetTeamById(int id)
        {

            return await _TeamService.GetTeam(id);
        }
        [HttpGet("GetCategoryId")]
        public async Task<Category> GetCategoryId(int id)
        {

            return await _TeamService.GetCategory(id);
        }

    }
}