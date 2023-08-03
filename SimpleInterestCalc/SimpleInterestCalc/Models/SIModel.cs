using System.ComponentModel.DataAnnotations;

namespace SimpleInterestCalc.Models
{
	public class SIModel
	{
		[Required]
        public Double PrincipalAmount { get; set; }
		[Required]
		public Double SimpleInterestRate { get; set; }
		[Required]
		public Double Time { get; set; }

	}
}
