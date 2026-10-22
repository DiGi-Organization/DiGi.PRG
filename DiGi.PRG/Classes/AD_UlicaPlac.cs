using DiGi.PRG.Enums;
using System.Collections.Generic;

namespace DiGi.PRG.Classes
{
    /// <summary>
    /// Street or square of the PRG address register (<c>AD_UlicaPlac</c>), as registered in TERYT ULIC.
    /// <para>The <c>geometria</c> element (a <c>gml:LineString</c>, <c>gml:MultiCurve</c>, <c>gml:Polygon</c> or <c>gml:MultiSurface</c>) is deliberately not modelled: DiGi.GML has no multi-geometry types, and the binder reads only declared properties, so leaving it out skips it safely. The council resolution references (<c>uchwala</c>) are left out as well; no file of the 21.10.2026 package carries one.</para>
    /// </summary>
    public class AD_UlicaPlac : AD_OgolnyObiekt
    {
        /// <summary>
        /// Gets or sets the full name as adopted by the municipal council, e.g. <c>Słowiański</c> or <c>Plac Henryka Pobożnego</c>.
        /// </summary>
        public string nazwaPelna { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the kind of object, or <see langword="null"/> when the code is not in <see cref="AD_RodzajObiektu"/>.
        /// <para>The schema has no TERYT feature (<c>ul.</c>, <c>pl.</c>); this code replaces it.</para>
        /// </summary>
        public AD_RodzajObiektu? rodzaj { get; set; }

        /// <summary>
        /// Gets or sets the part of the TERYT name that orders the street alphabetically.
        /// </summary>
        public string TERYTNazwa1 { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the remaining part of the TERYT name. When present, the full TERYT name is <see cref="TERYTNazwa2"/> followed by <see cref="TERYTNazwa1"/>.
        /// </summary>
        public string? TERYTNazwa2 { get; set; }

        /// <summary>
        /// Gets or sets the TERYT ULIC street identifier. A string, so leading zeros (<c>03513</c>) survive; matches <c>OT_SKJZ_L.identyfikatorULIC</c> of BDOT10k.
        /// </summary>
        public string? identyfikatorULIC { get; set; }

        /// <summary>
        /// Gets or sets the name in a minority language. Optional in the schema; absent from every file of the 21.10.2026 package.
        /// </summary>
        public string? nazwaJezykMniejszosci { get; set; }

        /// <summary>
        /// Gets or sets the references (<c>xlink:href</c>, <c>#gml:id</c>) to the localities the street lies in.
        /// </summary>
        public List<string>? miejsce { get; set; }

        /// <summary>
        /// Gets or sets the references (<c>xlink:href</c>, <c>#gml:id</c>) to the address points on the street, the reverse of <see cref="AD_PunktAdresowy.ulica2"/>.
        /// </summary>
        public List<string>? adres2 { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AD_UlicaPlac"/> class.
        /// </summary>
        public AD_UlicaPlac()
        {
        }
    }
}
