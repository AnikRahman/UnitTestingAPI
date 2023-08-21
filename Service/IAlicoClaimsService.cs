using UnitTestingAPI.Domain;

namespace UnitTestingAPI.Service
{
	public interface IAlicoClaimsService
	{
		Task<IEnumerable<AlicoClaims>> GetAllClaimsAsync();
		Task<AlicoClaims?> GetClaimByIdAsync(Guid id);
		Task AddClaimAsync(AlicoClaims claims);
		Task UpdateClaimAsync(AlicoClaims claims);
		Task DeleteClaimAsync(Guid id);
	}
}
