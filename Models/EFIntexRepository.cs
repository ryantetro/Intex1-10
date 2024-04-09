namespace Intex1_10.Models;

public class EFIntexRepository : IIntexRepository
{
    private IntexDatabaseContext _context;
    
    public EFIntexRepository(IntexDatabaseContext temp)
    {
        _context = temp;
    }

    public IQueryable<Customer> Customers => _context.Customers;
}