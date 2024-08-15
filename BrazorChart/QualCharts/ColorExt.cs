using System.Drawing;

namespace QualCharts
{
    /// <summary>
    /// 色を文字列に変換
    /// </summary>
    public static class ColorExt
    {
        /// <summary>
        /// =>rgba(255,255,255,1.0)
        /// </summary>
        /// <param name="color"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public static string ToRgbaString(this Color color, double alpha = 1.0)
        {
            var a=alpha>1 ? 1: 
                (0>alpha ? 0:alpha);
            return $"rgba({color.R},{color.G},{color.B},{alpha.ToString("0.0")})";
        }
    }
}
