using EntityFramework.DynamicFilters;
using PTC.DOTIC.EntityFramework;

namespace PTC.DOTIC.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly DOTICDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(DOTICDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
