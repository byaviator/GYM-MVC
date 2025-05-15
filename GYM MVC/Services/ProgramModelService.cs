using GYM_MVC.Models;
using GYM_MVC.Contexts;
using System.Net.Http.Headers;

namespace GYM_MVC.Services;

public class ProgramModelService
{
    AppDbContext _context = new AppDbContext();

    #region Create

    public void Create(ProgramModel pm)
    {
        _context.Programs.Add(pm);
        _context.SaveChanges();
    }

    #endregion

    #region Read

    public List<ProgramModel> GetAllProgramModels()
    {
        return _context.Programs.ToList();
    }

    #endregion

    #region 
    #endregion

    #region 
    #endregion
}
