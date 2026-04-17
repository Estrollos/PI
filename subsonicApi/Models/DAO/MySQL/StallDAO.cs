using Microsoft.EntityFrameworkCore;
using subsonicApi.Models.DAO.Interfaces;

public class StallDAO : IStallDAO {
    private readonly AppDbContext _context;

    public StallDAO(AppDbContext context) {
        _context = context;
    }

    public async Task<List<StallDTO>> GetAll() {
        return await _context.Stalls.ToListAsync();
    }

    public async Task<StallDTO> GetById(int id) {
        return await _context.Stalls.FindAsync(id);
    }

    public async Task Create(StallDTO dto) {
        _context.Stalls.Add(dto);
        await _context.SaveChangesAsync();
    }

    public async Task Update(StallDTO dto) {
        _context.Stalls.Update(dto);
        await _context.SaveChangesAsync();
    }
}