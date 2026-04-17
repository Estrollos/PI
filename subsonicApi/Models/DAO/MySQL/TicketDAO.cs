using Microsoft.EntityFrameworkCore;
using subsonicApi.Models.DAO.Interfaces;

public class TicketDAO : ITicketDAO
{
    private readonly AppDbContext _context;

    public TicketDAO(AppDbContext context) {
        _context = context;
    }

    public async Task<List<TicketDTO>> GetAll() {
        return await _context.Tickets.ToListAsync();
    }

    public async Task<TicketDTO> GetById(int id) {
        return await _context.Tickets.FindAsync(id);
    }

    public async Task Update(TicketDTO dto) {
        _context.Tickets.Update(dto);
        await _context.SaveChangesAsync();
    }  
}