using Microsoft.EntityFrameworkCore;
using subsonicApi.Models.DAO.Interfaces;

public class SpaceDAO : ISpaceDAO
{
    private readonly AppDbContext _context;

    public SpaceDAO(AppDbContext context) {
        _context = context;
    }

    public async Task<List<SpaceDTO>> GetAll() {
        return await _context.Spaces.ToListAsync();
    }

    public async Task<SpaceDTO> GetById(int id) {
        return await _context.Spaces.FindAsync(id);
    }

    public async Task Update(SpaceDTO dto) {
        _context.Spaces.Update(dto);
        await _context.SaveChangesAsync();
    }
}