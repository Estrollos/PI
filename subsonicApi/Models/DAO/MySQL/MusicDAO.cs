using Microsoft.EntityFrameworkCore;
using subsonicApi.Models.DAO.Interfaces;

public class MusicDAO : IMusicDAO
{
    private readonly AppDbContext _context;

    public MusicDAO(AppDbContext context) {
        _context = context;
    }

    public async Task<List<MusicDTO>> GetAll() {
        return await _context.Musics.ToListAsync();
    }

    public async Task<MusicDTO> GetById(int id) {
        return await _context.Musics.FindAsync(id);
    }

}