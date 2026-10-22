using System;

namespace DiGi.PRG.Classes
{
    /// <summary>
    /// Spatial information infrastructure (IIP) identifier of a PRG object (<c>AD_IdentyfikatorIIP</c>).
    /// </summary>
    public class AD_IdentyfikatorIIP : GML.Classes.GML
    {
        /// <summary>
        /// Gets or sets the local identifier given by the data provider, unique in <see cref="przestrzenNazw"/>.
        /// </summary>
        public string lokalnyId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the namespace of the data set the object comes from, e.g. <c>PL.PZGIK.200</c>.
        /// </summary>
        public string przestrzenNazw { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the version identifier of the object.
        /// <para>An <c>xs:dateTime</c> written with an offset (<c>2024-11-21T19:10:44+02:00</c>). It is a <see cref="DateTimeOffset"/> so the offset survives, which a <see cref="DateTime"/> would convert into the local time of the machine.</para>
        /// </summary>
        public DateTimeOffset? wersjaId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AD_IdentyfikatorIIP"/> class.
        /// </summary>
        public AD_IdentyfikatorIIP()
        {
        }
    }
}
