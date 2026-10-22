using System.ComponentModel;

namespace DiGi.PRG.Enums
{
    /// <summary>
    /// Kind of locality in the PRG address schema (code list <c>AD_RodzajMiejscowosciType</c>, the TERYT SIMC <c>RM</c> codes).
    /// <para>The <see cref="DescriptionAttribute"/> holds the code written in the GML files. Member names follow the schema's <c>gml:description</c>, except <see cref="czescMiejscowosci"/>, which the schema misspells <c>czescMiejcowosci</c>.</para>
    /// </summary>
    public enum AD_RodzajMiejscowosci
    {
        /// <summary>
        /// Part of a locality.
        /// </summary>
        [Description("00")] czescMiejscowosci,

        /// <summary>
        /// Village.
        /// </summary>
        [Description("01")] wies,

        /// <summary>
        /// Colony.
        /// </summary>
        [Description("02")] kolonia,

        /// <summary>
        /// Hamlet.
        /// </summary>
        [Description("03")] przysiolek,

        /// <summary>
        /// Settlement.
        /// </summary>
        [Description("04")] osada,

        /// <summary>
        /// Forest settlement.
        /// </summary>
        [Description("05")] osadaLesna,

        /// <summary>
        /// Housing estate.
        /// </summary>
        [Description("06")] osiedle,

        /// <summary>
        /// Mountain hostel.
        /// </summary>
        [Description("07")] schroniskoTurystyczne,

        /// <summary>
        /// District of the capital city of Warsaw.
        /// </summary>
        [Description("95")] dzielnicaWarszawy,

        /// <summary>
        /// Town or city.
        /// </summary>
        [Description("96")] miasto,

        /// <summary>
        /// Delegation (an administrative part of a city).
        /// </summary>
        [Description("98")] delegatura,

        /// <summary>
        /// Part of a town or city.
        /// </summary>
        [Description("99")] czescMiasta,
    }
}
