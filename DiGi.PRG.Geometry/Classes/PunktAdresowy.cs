using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Classes;
using DiGi.PRG.Classes;
using DiGi.PRG.Enums;
using System;

namespace DiGi.PRG.Geometry.Classes
{
    /// <summary>
    /// Represents a PRG address point (<see cref="AD_PunktAdresowy"/>) as a geometric point, together with the locality and the street it refers to.
    /// <para>The geometry is converted by <see cref="Convert.ToDiGi(GML.Classes.Point?)"/>, easting first, so it is <see langword="null"/> when the source point cannot be represented. The locality and the street are the features the point's <c>xlink:href</c> references resolve to; <see cref="Create.PunktyAdresowe(GML.Classes.FeatureCollection?)"/> resolves them.</para>
    /// </summary>
    public class PunktAdresowy : VisualPoint2D
    {
        private readonly AD_PunktAdresowy? aD_PunktAdresowy;
        private readonly AD_Miejscowosc? aD_Miejscowosc;
        private readonly AD_UlicaPlac? aD_UlicaPlac;

        /// <summary>
        /// Initializes a new instance of the <see cref="PunktAdresowy"/> class. The three input objects are held as private clones.
        /// </summary>
        /// <param name="aD_PunktAdresowy">The address point.</param>
        /// <param name="aD_Miejscowosc">The locality the point refers to, or <see langword="null"/> when its reference does not resolve.</param>
        /// <param name="aD_UlicaPlac">The street the point refers to, or <see langword="null"/> for a village address or when its reference does not resolve.</param>
        /// <param name="pointAppearance">The point appearance of the object.</param>
        public PunktAdresowy(AD_PunktAdresowy? aD_PunktAdresowy, AD_Miejscowosc? aD_Miejscowosc, AD_UlicaPlac? aD_UlicaPlac, IPointAppearance? pointAppearance)
            : base(Convert.ToDiGi(aD_PunktAdresowy?.georeferencja), pointAppearance)
        {
            this.aD_PunktAdresowy = GML.Query.Clone(aD_PunktAdresowy);
            this.aD_Miejscowosc = GML.Query.Clone(aD_Miejscowosc);
            this.aD_UlicaPlac = GML.Query.Clone(aD_UlicaPlac);
        }

        /// <summary> Gets a clone of the address point. </summary>
        public AD_PunktAdresowy? AD_PunktAdresowy
        {
            get
            {
                return GML.Query.Clone(aD_PunktAdresowy);
            }
        }

        /// <summary> Gets a clone of the locality the point refers to. </summary>
        public AD_Miejscowosc? AD_Miejscowosc
        {
            get
            {
                return GML.Query.Clone(aD_Miejscowosc);
            }
        }

        /// <summary> Gets a clone of the street the point refers to, or <see langword="null"/> for a village address. </summary>
        public AD_UlicaPlac? AD_UlicaPlac
        {
            get
            {
                return GML.Query.Clone(aD_UlicaPlac);
            }
        }

        /// <summary> Gets the local identifier of the address point. </summary>
        public string? lokalnyId
        {
            get
            {
                return aD_PunktAdresowy?.idIIP?.lokalnyId;
            }
        }

        /// <summary> Gets the version identifier of the address point. </summary>
        public DateTimeOffset? wersjaId
        {
            get
            {
                return aD_PunktAdresowy?.idIIP?.wersjaId;
            }
        }

        /// <summary> Gets the house number, e.g. <c>6A</c> or <c>2/4</c>. </summary>
        public string? numerPorzadkowy
        {
            get
            {
                return aD_PunktAdresowy?.numerPorzadkowy;
            }
        }

        /// <summary> Gets the postal code. </summary>
        public string? kodPocztowy
        {
            get
            {
                return aD_PunktAdresowy?.kodPocztowy;
            }
        }

        /// <summary> Gets the full name of the street, or <see langword="null"/> for a village address. </summary>
        public string? ulicaNazwaPelna
        {
            get
            {
                return aD_UlicaPlac?.nazwaPelna;
            }
        }

        /// <summary> Gets the kind of the street, or <see langword="null"/> for a village address. </summary>
        public AD_RodzajObiektu? ulicaRodzaj
        {
            get
            {
                return aD_UlicaPlac?.rodzaj;
            }
        }

        /// <summary> Gets the TERYT ULIC identifier of the street, or <see langword="null"/> for a village address. </summary>
        public string? identyfikatorULIC
        {
            get
            {
                return aD_UlicaPlac?.identyfikatorULIC;
            }
        }

        /// <summary> Gets the name of the locality. </summary>
        public string? miejscowoscNazwa
        {
            get
            {
                return aD_Miejscowosc?.nazwa;
            }
        }

        /// <summary> Gets the kind of the locality. </summary>
        public AD_RodzajMiejscowosci? miejscowoscRodzaj
        {
            get
            {
                return aD_Miejscowosc?.rodzaj;
            }
        }

        /// <summary> Gets the TERYT SIMC identifier of the locality. </summary>
        public string? identyfikatorSIMC
        {
            get
            {
                return aD_Miejscowosc?.identyfikatorSIMC;
            }
        }

        /// <summary> Gets the seven-digit TERYT code of the municipality the locality lies in. </summary>
        public string? TERYTGminy
        {
            get
            {
                return aD_Miejscowosc?.TERYTGminy;
            }
        }
    }
}
