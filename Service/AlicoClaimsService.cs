using UnitTestingAPI.Domain;
using UnitTestingAPI.Repository;

namespace UnitTestingAPI.Service
{
	public class AlicoClaimsService : IAlicoClaimsService
	{

		private readonly IUnitOfWork _unitOfWork;

		public AlicoClaimsService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<IEnumerable<AlicoClaims>> GetAllClaimsAsync()
		{
			return await _unitOfWork.AlicoClaimsRepository.GetAllAsync();
		}

		public async Task<AlicoClaims?> GetClaimByIdAsync(Guid id)
		{
			return await _unitOfWork.AlicoClaimsRepository.GetByIdAsync(id);
		}

		public async Task AddClaimAsync(AlicoClaims claims)
		{
			_unitOfWork.AlicoClaimsRepository.Add(claims);
			await _unitOfWork.CommitAsync();
		}

		public async Task UpdateClaimAsync(AlicoClaims claims)
		{
			_unitOfWork.AlicoClaimsRepository.Update(claims);
			await _unitOfWork.CommitAsync();
		}

		public async Task DeleteClaimAsync(Guid id)
		{
			var claim = await _unitOfWork.AlicoClaimsRepository.GetByIdAsync(id);
			if (claim != null)
			{
				_unitOfWork.AlicoClaimsRepository.Remove(claim);
				await _unitOfWork.CommitAsync();
			}
		}
	}
}
