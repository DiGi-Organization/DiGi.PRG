using DiGi.GML.Classes;
using DiGi.PRG.Enums;
using System.Collections.Generic;

namespace DiGi.PRG.Classes
{
    /// <summary>
    /// Locality of the PRG address register (<c>AD_Miejscowosc</c>): a town, a village or a part of one, as registered in TERYT SIMC.
    /// </summary>
    public class AD_Miejscowosc : AD_OgolnyObiekt
    {
        /// <summary>
        /// Gets or sets the name of the locality.
        /// </summary>
        public string nazwa { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the kind of locality, or <see langword="null"/> when the code is not in <see cref="AD_RodzajMiejscowosci"/>.
        /// </summary>
        public AD_RodzajMiejscowosci? rodzaj { get; set; }

        /// <summary>
        /// Gets or sets the TERYT SIMC identifier of the locality. A string, so leading zeros (<c>0954047</c>) survive.
        /// </summary>
        public string identyfikatorSIMC { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the identifier in the national register of geographical names (PRNG). Written empty in every file of the 21.10.2026 package.
        /// </summary>
        public string? identyfikatorPRNG { get; set; }

        /// <summary>
        /// Gets or sets the reference point of the locality. Its <c>gml:pos</c> is northing-first; see <c>DiGi.PRG.Geometry.Convert.ToDiGi(Point?)</c>.
        /// </summary>
        public Point? georeferencja { get; set; }

        /// <summary>
        /// Gets or sets the seven-digit TERYT code of the municipality (<c>gmina</c>) the locality lies in, e.g. <c>0262011</c>.
        /// </summary>
        public string TERYTGminy { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name in a minority language. Optional in the schema; absent from every file of the 21.10.2026 package.
        /// </summary>
        public string? nazwaJezykMniejszosci { get; set; }

        /// <summary>
        /// Gets or sets the references (<c>xlink:href</c>, <c>#gml:id</c>) to the streets of the locality, the reverse of <see cref="AD_UlicaPlac.miejsce"/>. Optional in the schema; absent from every file of the 21.10.2026 package.
        /// </summary>
        public List<string>? ulica1 { get; set; }

        /// <summary>
        /// Gets or sets the references (<c>xlink:href</c>, <c>#gml:id</c>) to the address points of the locality, the reverse of <see cref="AD_PunktAdresowy.miejscowosc"/>. Optional in the schema; absent from every file of the 21.10.2026 package.
        /// </summary>
        public List<string>? adres1 { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AD_Miejscowosc"/> class.
        /// </summary>
        public AD_Miejscowosc()
        {
        }
    }
}
