using DiGi.GML.Classes;
using System;

namespace DiGi.PRG.Classes
{
    /// <summary>
    /// Address point of the PRG address register (<c>AD_PunktAdresowy</c>).
    /// <para>The point does not carry its street or locality inline: <see cref="miejscowosc"/> and <see cref="ulica2"/> are references to an <see cref="AD_Miejscowosc"/> and an <see cref="AD_UlicaPlac"/> of the same file, resolved by <c>DiGi.PRG.Geometry.Create.PunktyAdresowe</c>.</para>
    /// </summary>
    public class AD_PunktAdresowy : AD_OgolnyObiekt
    {
        /// <summary>
        /// Gets or sets the house number. Free text: <c>12</c>, <c>6A</c>, <c>2/4</c>, <c>13/17a</c>, <c>9-9</c>.
        /// </summary>
        public string numerPorzadkowy { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the position of the point, usually near the entrance of the building. Its <c>gml:pos</c> is northing-first; see <c>DiGi.PRG.Geometry.Convert.ToDiGi(Point?)</c>.
        /// </summary>
        public Point? georeferencja { get; set; }

        /// <summary>
        /// Gets or sets the postal code, e.g. <c>59-220</c>.
        /// </summary>
        public string? kodPocztowy { get; set; }

        /// <summary>
        /// Gets or sets the date the number was assigned, when recorded.
        /// </summary>
        public DateTime? dataNadania { get; set; }

        /// <summary>
        /// Gets or sets the reference (<c>xlink:href</c>, <c>#gml:id</c>) to the locality of the point. Always present.
        /// </summary>
        public string? miejscowosc { get; set; }

        /// <summary>
        /// Gets or sets the reference (<c>xlink:href</c>, <c>#gml:id</c>) to the street or square of the point, or <see langword="null"/> for an address numbered within the locality only (a village address).
        /// </summary>
        public string? ulica2 { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AD_PunktAdresowy"/> class.
        /// </summary>
        public AD_PunktAdresowy()
        {
        }
    }
}
