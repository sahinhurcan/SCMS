using System.Collections.Generic;

namespace SCMS.Shared
{
	public class BarChartModel
	{
		public ICollection<string> Labels { get; set; }
		public ICollection<int> Data { get; set; }
	}
}
