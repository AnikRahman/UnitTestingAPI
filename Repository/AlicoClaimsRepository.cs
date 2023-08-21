using UnitTestingAPI.Context;
using UnitTestingAPI.Domain;

namespace UnitTestingAPI.Repository
{
	public class AlicoClaimsRepository : Repository<AlicoClaims>, IAlicoClaimsRepository
	{
		public AlicoClaimsRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
