using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApp.Pages
{
    public class DevicesPageFlyoutMenuItem
    {
        public DevicesPageFlyoutMenuItem()
        {
            TargetType = typeof(DevicesPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}