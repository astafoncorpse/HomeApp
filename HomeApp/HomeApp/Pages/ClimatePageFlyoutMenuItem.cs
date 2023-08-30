using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApp.Pages
{
    public class ClimatePageFlyoutMenuItem
    {
        public ClimatePageFlyoutMenuItem()
        {
            TargetType = typeof(ClimatePageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}