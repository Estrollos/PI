public class MySQLDAOFactory : DAOFactory {
    private readonly AppDbContext _context;

    public MySQLDAOFactory(AppDbContext context) {
        _context = context;
    }

    public EventDAO CreateEventDAO() => new EventDAOMySQL(_context);
}