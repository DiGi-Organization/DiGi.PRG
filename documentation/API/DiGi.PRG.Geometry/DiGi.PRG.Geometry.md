#### [DiGi\.PRG\.Geometry](DiGi.PRG.Geometry.Overview.md 'DiGi\.PRG\.Geometry\.Overview')

## DiGi\.PRG\.Geometry Namespace
### Classes

<a name='DiGi.PRG.Geometry.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Fields

<a name='DiGi.PRG.Geometry.Convert.SrsName'></a>

## Convert\.SrsName Field

The `srsName` of every point in the PRG address package: EPSG:2180 in its URN form, which carries the EPSG axis order \(northing, easting\)\.

```csharp
public const string SrsName = "urn:ogc:def:crs:EPSG::2180";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.PRG.Geometry.Convert.ToDiGi(thisDiGi.GML.Classes.Point)'></a>

## Convert\.ToDiGi\(this Point\) Method

Converts a PRG `gml:Point` to a [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') in the axis order of DiGi\.BDOT10k, easting first\.

PRG writes `gml:pos` northing-first under [SrsName](DiGi.PRG.Geometry.md#DiGi.PRG.Geometry.Convert.SrsName 'DiGi\.PRG\.Geometry\.Convert\.SrsName'), while BDOT10k writes its coordinates easting-first under the legacy `EPSG:2180` name, and `DiGi.BDOT10k.Geometry` reads them unswapped. The two values are therefore swapped here: read as written, the address points of pl. Słowiański in Legnica (ULIC 20295) lie 103 km from the BDOT10k carriageway of the same square; swapped, 31 to 83 m.

A point under any other `srsName`, including none, returns [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'): its axis order is not known, and guessing would misplace it by about 100 km without an error.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? ToDiGi(this DiGi.GML.Classes.Point? point);
```
#### Parameters

<a name='DiGi.PRG.Geometry.Convert.ToDiGi(thisDiGi.GML.Classes.Point).point'></a>

`point` [DiGi\.GML\.Classes\.Point](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.point 'DiGi\.GML\.Classes\.Point')

The GML point to convert\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
The [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') \(easting, northing\); or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when the input is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), its `srsName` is not [SrsName](DiGi.PRG.Geometry.md#DiGi.PRG.Geometry.Convert.SrsName 'DiGi\.PRG\.Geometry\.Convert\.SrsName'), its position does not hold exactly two values, or a value is not finite\.

<a name='DiGi.PRG.Geometry.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.PRG.Geometry.Create.PunktyAdresowe(DiGi.GML.Classes.FeatureCollection)'></a>

## Create\.PunktyAdresowe\(FeatureCollection\) Method

Builds the address points of a PRG feature collection, each with the locality and the street its references point to\.

A point names its locality ([DiGi\.PRG\.Classes\.AD\_PunktAdresowy\.miejscowosc](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.classes.ad_punktadresowy.miejscowosc 'DiGi\.PRG\.Classes\.AD\_PunktAdresowy\.miejscowosc')) and street ([DiGi\.PRG\.Classes\.AD\_PunktAdresowy\.ulica2](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.classes.ad_punktadresowy.ulica2 'DiGi\.PRG\.Classes\.AD\_PunktAdresowy\.ulica2')) only by `xlink:href="#gml:id"`. Every [DiGi\.PRG\.Classes\.AD\_Miejscowosc](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.classes.ad_miejscowosc 'DiGi\.PRG\.Classes\.AD\_Miejscowosc') and [DiGi\.PRG\.Classes\.AD\_UlicaPlac](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.classes.ad_ulicaplac 'DiGi\.PRG\.Classes\.AD\_UlicaPlac') of the collection is indexed by its `gml:id` in one pass, then each reference is looked up. A reference that is not local (no leading `#`) or names no feature of the collection resolves to [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'); the point is still returned.

Feature members of any other class, such as a BDOT10k object in the same file or an element no assembly models, are skipped without throwing.

```csharp
public static System.Collections.Generic.List<DiGi.PRG.Geometry.Classes.PunktAdresowy>? PunktyAdresowe(DiGi.GML.Classes.FeatureCollection? featureCollection);
```
#### Parameters

<a name='DiGi.PRG.Geometry.Create.PunktyAdresowe(DiGi.GML.Classes.FeatureCollection).featureCollection'></a>

`featureCollection` [DiGi\.GML\.Classes\.FeatureCollection](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.featurecollection 'DiGi\.GML\.Classes\.FeatureCollection')

The feature collection to read\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PunktAdresowy](DiGi.PRG.Geometry.Classes.md#DiGi.PRG.Geometry.Classes.PunktAdresowy 'DiGi\.PRG\.Geometry\.Classes\.PunktAdresowy')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The address points in document order; an empty list when the collection holds none; or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when the collection is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.PRG.Geometry.Create.PunktyAdresowe(string)'></a>

## Create\.PunktyAdresowe\(string\) Method

Loads the address points of a PRG address GML file \(`prgad`, `PRGAD.xsd`\), each with its locality and street\.

```csharp
public static System.Collections.Generic.List<DiGi.PRG.Geometry.Classes.PunktAdresowy>? PunktyAdresowe(string? path);
```
#### Parameters

<a name='DiGi.PRG.Geometry.Create.PunktyAdresowe(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the GML file\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PunktAdresowy](DiGi.PRG.Geometry.Classes.md#DiGi.PRG.Geometry.Classes.PunktAdresowy 'DiGi\.PRG\.Geometry\.Classes\.PunktAdresowy')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The address points in document order; an empty list when the file holds none; or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when the path is empty, the file does not exist or its root is not a [DiGi\.GML\.Classes\.FeatureCollection](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.featurecollection 'DiGi\.GML\.Classes\.FeatureCollection')\.

<a name='DiGi.PRG.Geometry.Create.PunktyAdresowe(System.IO.Stream)'></a>

## Create\.PunktyAdresowe\(Stream\) Method

Loads the address points of a PRG address GML stream \(`prgad`, `PRGAD.xsd`\), each with its locality and street\.

```csharp
public static System.Collections.Generic.List<DiGi.PRG.Geometry.Classes.PunktAdresowy>? PunktyAdresowe(System.IO.Stream? stream);
```
#### Parameters

<a name='DiGi.PRG.Geometry.Create.PunktyAdresowe(System.IO.Stream).stream'></a>

`stream` [System\.IO\.Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream 'System\.IO\.Stream')

The stream holding the GML document\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PunktAdresowy](DiGi.PRG.Geometry.Classes.md#DiGi.PRG.Geometry.Classes.PunktAdresowy 'DiGi\.PRG\.Geometry\.Classes\.PunktAdresowy')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The address points in document order; an empty list when the stream holds none; or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when the stream is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') or its root is not a [DiGi\.GML\.Classes\.FeatureCollection](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.featurecollection 'DiGi\.GML\.Classes\.FeatureCollection')\.