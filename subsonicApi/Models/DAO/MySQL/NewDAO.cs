using Microsoft.EntityFrameworkCore;
using subsonicApi.Models.DAO.Interfaces;

public class NewDAO : INewDAO
{
    private readonly AppDbContext _context;

    public NewDAO(AppDbContext context) {
        _context = context;
    }

    public async Task<List<NewsDTO>> GetAll() {
        return await _context.News.ToListAsync();
    }

    public async Task<NewsDTO> GetById(int id) {
        return await _context.News.FindAsync(id);
    }
}