using System.Drawing;

namespace QualCharts
{
    /// <summary>
    /// カラーパレットクラス
    /// </summary>
    public class ColorPallet
    {
        /// <summary>
        /// プライマリカラー
        /// </summary>
        public Color Primary { get; init; }
        /// <summary>
        /// リンクカラー
        /// </summary>
        public Color Link { get; init; }
        /// <summary>
        /// インフォメーションカラー
        /// </summary>
        public Color Info { get; init; }
        /// <summary>
        /// サクセスカラー
        /// </summary>
        public Color Success { get; init; }
        /// <summary>
        /// ワーニングカラー
        /// </summary>
        public Color Warning { get; init; }
        /// <summary>
        /// デンジャーカラー
        /// </summary>
        public Color Danger { get; init; }
        /// <summary>
        /// ライト
        /// </summary>
        public Color Light { get; init; }
        /// <summary>
        /// ダーク
        /// </summary>
        public Color Dark { get; init; }
        /// <summary>
        /// カラーパレットディクショナリ
        /// </summary>
        public IReadOnlyDictionary<string, Color> Pallets => new Dictionary<string, Color>
        {
            {nameof(Primary), Primary},
            {nameof(Link), Link},
            {nameof(Info), Info},
            {nameof(Success), Success},
            {nameof(Warning), Warning},
            {nameof(Danger), Danger},
            {nameof(Light), Light},
            {nameof(Dark), Dark},
        };
        /// <summary>
        /// 標準カラーパレット
        /// </summary>
        public static ColorPallet Default => new ColorPallet
        {
            Primary=Color.FromArgb(0, 184, 156),
            Link=Color.FromArgb(41, 66, 255),
            Info=Color.FromArgb(76, 201, 255),
            Success=Color.FromArgb(58, 187, 129),
            Warning = Color.FromArgb(245, 171, 0),
            Danger = Color.FromArgb(255, 76, 112),
            Light=Color.FromArgb(229, 231, 235),
            Dark=Color.FromArgb(35, 39, 47)
        };
    }
 }
