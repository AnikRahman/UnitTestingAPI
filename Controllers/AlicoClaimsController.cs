using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTestingAPI.Domain;
using UnitTestingAPI.Service;

namespace UnitTestingAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AlicoClaimsController : ControllerBase
	{

		private readonly IAlicoClaimsService _claimsService;

		public AlicoClaimsController(IAlicoClaimsService claimsService)
		{
			_claimsService = claimsService;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<AlicoClaims>>> GetAllClaims()
		{
			var claims = await _claimsService.GetAllClaimsAsync();
			return Ok(claims);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<AlicoClaims>> GetClaimById(Guid id)
		{
			var claim = await _claimsService.GetClaimByIdAsync(id);
			if (claim == null)
			{
				return NotFound();
			}
			return Ok(claim);
		}

		[HttpPost]
		public async Task<ActionResult> AddClaim([FromBody] AlicoClaims claim)
		{
			await _claimsService.AddClaimAsync(claim);
			return CreatedAtAction(nameof(GetClaimById), new { id = claim.Id }, claim);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult> UpdateClaim(Guid id, [FromBody] AlicoClaims claim)
		{
			if (id != claim.Id)
			{
				return BadRequest();
			}

			await _claimsService.UpdateClaimAsync(claim);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> DeleteClaim(Guid id)
		{
			await _claimsService.DeleteClaimAsync(id);
			return NoContent();
		}
	}
}
