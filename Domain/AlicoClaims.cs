using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace UnitTestingAPI.Domain
{
	public class AlicoClaims
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public string? Designation { get; set; }
		public string? Email { get; set; }
		public DateTime? JoiningDate { get; set; }
		public bool IsWorking { get; set; }

		[JsonConverter(typeof(JsonStringEnumConverter))]
		public ProjectType CurrentProject { get; set; }
	}

	public enum ProjectType
	{
		[Display(Name = "Clics")]
		ProjectA,

		[Display(Name = "Paps")]
		ProjectB,

		[Display(Name = "Both Projects")]
		BothProjects
	}
}
