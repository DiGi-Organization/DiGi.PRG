using DiGi.Geometry.Planar.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.PRG.Geometry
{
    public static partial class Convert
    {
        /// <summary>
        /// The <c>srsName</c> of every point in the PRG address package: EPSG:2180 in its URN form, which carries the EPSG axis order (northing, easting).
        /// </summary>
        public const string SrsName = "urn:ogc:def:crs:EPSG::2180";

        /// <summary>
        /// Converts a PRG <c>gml:Point</c> to a <see cref="Point2D"/> in the axis order of DiGi.BDOT10k, easting first.
        /// <para>PRG writes <c>gml:pos</c> northing-first under <see cref="SrsName"/>, while BDOT10k writes its coordinates easting-first under the legacy <c>EPSG:2180</c> name, and <c>DiGi.BDOT10k.Geometry</c> reads them unswapped. The two values are therefore swapped here: read as written, the address points of pl. Słowiański in Legnica (ULIC 20295) lie 103 km from the BDOT10k carriageway of the same square; swapped, 31 to 83 m.</para>
        /// <para>A point under any other <c>srsName</c>, including none, returns <see langword="null"/>: its axis order is not known, and guessing would misplace it by about 100 km without an error.</para>
        /// </summary>
        /// <param name="point">The GML point to convert.</param>
        /// <returns>The <see cref="Point2D"/> (easting, northing); or <see langword="null"/> when the input is <see langword="null"/>, its <c>srsName</c> is not <see cref="SrsName"/>, its position does not hold exactly two values, or a value is not finite.</returns>
        public static Point2D? ToDiGi(this GML.Classes.Point? point)
        {
            if (point == null || !string.Equals(point.srsName, SrsName, StringComparison.Ordinal))
            {
                return null;
            }

            List<double> values = point.pos;
            if (values == null || values.Count != 2)
            {
                return null;
            }

            double northing = values[0];
            double easting = values[1];
            if (double.IsNaN(northing) || double.IsInfinity(northing) || double.IsNaN(easting) || double.IsInfinity(easting))
            {
                return null;
            }

            return new Point2D(easting, northing);
        }
    }
}
