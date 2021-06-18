using System.Collections.Generic;

namespace SCMS.Shared
{
	public class PageListModel
   {
      public IEnumerable<PostItem> Posts { get; set; }
      public Pager Pager { get; set; }
   }
}
