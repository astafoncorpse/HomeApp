﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApp.Pages
{
    public class GridPageFlyoutMenuItem
    {
        public GridPageFlyoutMenuItem()
        {
            TargetType = typeof(GridPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}