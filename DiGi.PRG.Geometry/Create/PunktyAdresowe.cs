using DiGi.GML.Classes;
using DiGi.GML.Interfaces;
using DiGi.PRG.Classes;
using DiGi.PRG.Geometry.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiGi.PRG.Geometry
{
    public static partial class Create
    {
        /// <summary>
        /// Loads the address points of a PRG address GML file (<c>prgad</c>, <c>PRGAD.xsd</c>), each with its locality and street.
        /// </summary>
        /// <param name="path">The path to the GML file.</param>
        /// <returns>The address points in document order; an empty list when the file holds none; or <see langword="null"/> when the path is empty, the file does not exist or its root is not a <see cref="FeatureCollection"/>.</returns>
        public static List<PunktAdresowy>? PunktyAdresowe(string? path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return null;
            }

            return PunktyAdresowe(GML.Convert.ToGML<FeatureCollection>(path)?.FirstOrDefault());
        }

        /// <summary>
        /// Loads the address points of a PRG address GML stream (<c>prgad</c>, <c>PRGAD.xsd</c>), each with its locality and street.
        /// </summary>
        /// <param name="stream">The stream holding the GML document.</param>
        /// <returns>The address points in document order; an empty list when the stream holds none; or <see langword="null"/> when the stream is <see langword="null"/> or its root is not a <see cref="FeatureCollection"/>.</returns>
        public static List<PunktAdresowy>? PunktyAdresowe(Stream? stream)
        {
            if (stream == null)
            {
                return null;
            }

            return PunktyAdresowe(GML.Convert.ToGML<FeatureCollection>(stream)?.FirstOrDefault());
        }

        /// <summary>
        /// Builds the address points of a PRG feature collection, each with the locality and the street its references point to.
        /// <para>A point names its locality (<see cref="AD_PunktAdresowy.miejscowosc"/>) and street (<see cref="AD_PunktAdresowy.ulica2"/>) only by <c>xlink:href="#gml:id"</c>. Every <see cref="AD_Miejscowosc"/> and <see cref="AD_UlicaPlac"/> of the collection is indexed by its <c>gml:id</c> in one pass, then each reference is looked up. A reference that is not local (no leading <c>#</c>) or names no feature of the collection resolves to <see langword="null"/>; the point is still returned.</para>
        /// <para>Feature members of any other class, such as a BDOT10k object in the same file or an element no assembly models, are skipped without throwing.</para>
        /// </summary>
        /// <param name="featureCollection">The feature collection to read.</param>
        /// <returns>The address points in document order; an empty list when the collection holds none; or <see langword="null"/> when the collection is <see langword="null"/>.</returns>
        public static List<PunktAdresowy>? PunktyAdresowe(FeatureCollection? featureCollection)
        {
            if (featureCollection == null)
            {
                return null;
            }

            List<IFeatureMember> featureMembers = featureCollection.featureMember ?? [];

            Dictionary<string, AD_Miejscowosc> miejscowosci = [];
            Dictionary<string, AD_UlicaPlac> ulicePlace = [];
            List<AD_PunktAdresowy> aD_PunktyAdresowe = [];
            foreach (IFeatureMember featureMember in featureMembers)
            {
                if (featureMember is AD_PunktAdresowy aD_PunktAdresowy)
                {
                    aD_PunktyAdresowe.Add(aD_PunktAdresowy);
                }
                else if (featureMember is AD_Miejscowosc aD_Miejscowosc && aD_Miejscowosc.id != null)
                {
                    miejscowosci[aD_Miejscowosc.id] = aD_Miejscowosc;
                }
                else if (featureMember is AD_UlicaPlac aD_UlicaPlac && aD_UlicaPlac.id != null)
                {
                    ulicePlace[aD_UlicaPlac.id] = aD_UlicaPlac;
                }
            }

            List<PunktAdresowy> result = [];
            foreach (AD_PunktAdresowy aD_PunktAdresowy in aD_PunktyAdresowe)
            {
                AD_Miejscowosc? aD_Miejscowosc = Resolve(miejscowosci, aD_PunktAdresowy.miejscowosc);
                AD_UlicaPlac? aD_UlicaPlac = Resolve(ulicePlace, aD_PunktAdresowy.ulica2);

                result.Add(new PunktAdresowy(aD_PunktAdresowy, aD_Miejscowosc, aD_UlicaPlac, null));
            }

            return result;

            static T? Resolve<T>(Dictionary<string, T> dictionary, string? href) where T : class
            {
                if (href == null || href.Length < 2 || href[0] != '#')
                {
                    return null;
                }

                return dictionary.TryGetValue(href.Substring(1), out T? value) ? value : null;
            }
        }
    }
}
