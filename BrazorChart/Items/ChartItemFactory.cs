using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrazorChart.Items
{
    public static class ChartItemFactory
    {
        public static ICollection<ChartItem> Create()
        {
            return 
                [
                    new() { Name = "A", Value = 5 },
                    new() {Name = "B", Value = 6 },
                    new(){Name = "C", Value = 1 },
                    new(){Name="D", Value = 4 },
                ];
        }
    }
}
