using PSC.Blazor.Components.Chartjs.Interfaces;
using PSC.Blazor.Components.Chartjs.Models.Radar;

namespace QualCharts
{
    /// <summary>
    /// チャートコンフィグ生成
    /// </summary>
    public static class ChartConfigFactory
    {
        /// <summary>
        /// レーダーチャートコンフィグ
        /// </summary>
        /// <returns></returns>
        public static IChartConfig CreateRaderConfig()
        {
            return new RadarChartConfig
            {
                Options = new RadarOptions
                {
                    Scales = new RadarOptionsScales
                    {
                        R = new RadarOptionsScalesRadius
                        {
                            Min = 1,
                            BeginAtZero = false
                        }
                    }
                },
            };
        }
    }
}
