using System.ComponentModel;

namespace DiGi.PRG.Enums
{
    /// <summary>
    /// Kind of street or square in the PRG address schema (code list <c>AD_RodzajObiektuType</c>).
    /// <para>The <see cref="DescriptionAttribute"/> holds the code written in the GML files; member names follow the schema's <c>gml:description</c>. The code records how the object was registered, not what its name says: Legnica's <c>Rynek</c> is <see cref="innyPowierzchniowy"/>, not <see cref="rynek"/>.</para>
    /// </summary>
    public enum AD_RodzajObiektu
    {
        /// <summary>
        /// Street.
        /// </summary>
        [Description("1")] ulica,

        /// <summary>
        /// Avenue.
        /// </summary>
        [Description("2")] aleja,

        /// <summary>
        /// Square.
        /// </summary>
        [Description("3")] plac,

        /// <summary>
        /// Small green square.
        /// </summary>
        [Description("4")] skwer,

        /// <summary>
        /// Boulevard.
        /// </summary>
        [Description("5")] bulwar,

        /// <summary>
        /// Roundabout.
        /// </summary>
        [Description("6")] rondo,

        /// <summary>
        /// Park.
        /// </summary>
        [Description("7")] park,

        /// <summary>
        /// Market square.
        /// </summary>
        [Description("8")] rynek,

        /// <summary>
        /// Highway (<c>szosa</c>).
        /// </summary>
        [Description("9")] szosa,

        /// <summary>
        /// Road.
        /// </summary>
        [Description("10")] droga,

        /// <summary>
        /// Housing estate.
        /// </summary>
        [Description("11")] osiedle,

        /// <summary>
        /// Garden.
        /// </summary>
        [Description("12")] ogrod,

        /// <summary>
        /// Island.
        /// </summary>
        [Description("13")] wyspa,

        /// <summary>
        /// Waterfront.
        /// </summary>
        [Description("14")] wybrzeze,

        /// <summary>
        /// Other linear object.
        /// </summary>
        [Description("15")] innyLiniowy,

        /// <summary>
        /// Other areal object.
        /// </summary>
        [Description("16")] innyPowierzchniowy,
    }
}
