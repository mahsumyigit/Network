using Microsoft.EntityFrameworkCore;
using network;

public class TeamRepository : ITeamRepository
{
    NetworkDbContext _context;

    public TeamRepository(NetworkDbContext context)
    {
        _context = context;
    }

    public async Task<Team> CreateTeam(Team team)
    {
        try
       { await _context.Set<Team>().AddAsync(team);
        await _context.SaveChangesAsync();
        return team;}
        catch(Exception ex)
        {
            return null;
        }
    }

    public async Task<Team> DeleteTeam(Team team)
    {
    try
            {_context.Set<Team>().Remove(team);
            _context.SaveChangesAsync();
            return team;}
            catch(Exception ex)
            {
                return null;
            }
        
    }

    public async Task<List<Category>> GetAllCategory()
    {
        try
        {
            return await _context.Set<Category>().ToListAsync();
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<List<Team>> GetAllTeam()
    {
        try
        {
            return await _context.Set<Team>().ToListAsync();
        }
        catch (Exception ex)
        {
            
            return null;
        }
    }

    public async Task<Category> GetCategory(int Id)
    {
        try
        {
            var GetCategoryById=await _context.Set<Category>().SingleOrDefaultAsync(p=>p.Id==Id);
        if (GetCategoryById !=null)
        {
            return GetCategoryById;
        }
        else
        {
            return null;
        }

       
        }
        catch (System.Exception ex)
        {
            
           return null;
        }
    }

    public async Task<Team> GetTeam(int Id)
    {
        try
        {
            var GetTeamById = await _context.Set<Team>().SingleOrDefaultAsync(p=>p.Id==Id);
            if (GetTeamById != null)
            {
                return GetTeamById;
            }
            else
            {
                return null;
            }
        }
        catch (Exception ex)
        {
            
            return null;
        }
    }
}
