using DiGi.PRG.Interfaces;
using System;

namespace DiGi.PRG.Classes
{
    /// <summary>
    /// Base class of every PRG address feature (<c>AD_OgolnyObiekt</c>): its identifier and the lifespan of its version.
    /// </summary>
    public abstract class AD_OgolnyObiekt : GML.Classes.GML, IAD_OgolnyObiekt
    {
        /// <summary>
        /// Gets or sets the spatial information infrastructure identifier of the object.
        /// </summary>
        public AD_IdentyfikatorIIP? idIIP { get; set; }

        /// <summary>
        /// Gets or sets the start of the object version.
        /// <para>The files write it without an offset (<c>2017-04-07T15:13:07</c>), so it is a <see cref="DateTime"/>: a <see cref="DateTimeOffset"/> would invent the offset of the machine that parses it.</para>
        /// </summary>
        public DateTime? poczatekWersjiObiektu { get; set; }

        /// <summary>
        /// Gets or sets the end of the object version. Optional in the schema; absent from every file of the 21.10.2026 package.
        /// </summary>
        public DateTime? koniecWersjiObiektu { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AD_OgolnyObiekt"/> class.
        /// </summary>
        public AD_OgolnyObiekt()
        {
        }
    }
}
