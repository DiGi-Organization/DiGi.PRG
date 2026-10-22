#### [DiGi\.PRG\.Geometry](DiGi.PRG.Geometry.Overview.md 'DiGi\.PRG\.Geometry\.Overview')

## DiGi\.PRG\.Geometry\.Classes Namespace
### Classes

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy'></a>

## PunktAdresowy Class

Represents a PRG address point \([AD\_PunktAdresowy](DiGi.PRG.Geometry.Classes.md#DiGi.PRG.Geometry.Classes.PunktAdresowy.AD_PunktAdresowy 'DiGi\.PRG\.Geometry\.Classes\.PunktAdresowy\.AD\_PunktAdresowy')\) as a geometric point, together with the locality and the street it refers to\.

The geometry is converted by [ToDiGi\(this Point\)](DiGi.PRG.Geometry.md#DiGi.PRG.Geometry.Convert.ToDiGi(thisDiGi.GML.Classes.Point) 'DiGi\.PRG\.Geometry\.Convert\.ToDiGi\(this DiGi\.GML\.Classes\.Point\)'), easting first, so it is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when the source point cannot be represented. The locality and the street are the features the point's `xlink:href` references resolve to; [PunktyAdresowe\(FeatureCollection\)](DiGi.PRG.Geometry.md#DiGi.PRG.Geometry.Create.PunktyAdresowe(DiGi.GML.Classes.FeatureCollection) 'DiGi\.PRG\.Geometry\.Create\.PunktyAdresowe\(DiGi\.GML\.Classes\.FeatureCollection\)') resolves them.

```csharp
public class PunktAdresowy : DiGi.Geometry.Visual.Planar.Classes.VisualPoint2D
```

Inheritance [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject') → [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject') → [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') → [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject') → [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject') → [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject') → [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual') → [DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.core.interfaces.igeometryobject 'DiGi\.Geometry\.Object\.Core\.Interfaces\.IGeometryObject') → [DiGi\.Geometry\.Visual\.Core\.Classes\.Visual&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2')[DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ipointappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.visual-2 'DiGi\.Geometry\.Visual\.Core\.Classes\.Visual\`2') → [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject') → [DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.object.planar.interfaces.igeometry2dobject 'DiGi\.Geometry\.Object\.Planar\.Interfaces\.IGeometry2DObject') → [DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPoint2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.planar.classes.visualpoint2d 'DiGi\.Geometry\.Visual\.Planar\.Classes\.VisualPoint2D') → PunktAdresowy
### Constructors

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.PunktAdresowy(DiGi.PRG.Classes.AD_PunktAdresowy,DiGi.PRG.Classes.AD_Miejscowosc,DiGi.PRG.Classes.AD_UlicaPlac,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance)'></a>

## PunktAdresowy\(AD\_PunktAdresowy, AD\_Miejscowosc, AD\_UlicaPlac, IPointAppearance\) Constructor

Initializes a new instance of the [PunktAdresowy](DiGi.PRG.Geometry.Classes.md#DiGi.PRG.Geometry.Classes.PunktAdresowy 'DiGi\.PRG\.Geometry\.Classes\.PunktAdresowy') class\. The three input objects are held as private clones\.

```csharp
public PunktAdresowy(DiGi.PRG.Classes.AD_PunktAdresowy? aD_PunktAdresowy, DiGi.PRG.Classes.AD_Miejscowosc? aD_Miejscowosc, DiGi.PRG.Classes.AD_UlicaPlac? aD_UlicaPlac, DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance? pointAppearance);
```
#### Parameters

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.PunktAdresowy(DiGi.PRG.Classes.AD_PunktAdresowy,DiGi.PRG.Classes.AD_Miejscowosc,DiGi.PRG.Classes.AD_UlicaPlac,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance).aD_PunktAdresowy'></a>

`aD_PunktAdresowy` [DiGi\.PRG\.Classes\.AD\_PunktAdresowy](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.classes.ad_punktadresowy 'DiGi\.PRG\.Classes\.AD\_PunktAdresowy')

The address point\.

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.PunktAdresowy(DiGi.PRG.Classes.AD_PunktAdresowy,DiGi.PRG.Classes.AD_Miejscowosc,DiGi.PRG.Classes.AD_UlicaPlac,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance).aD_Miejscowosc'></a>

`aD_Miejscowosc` [DiGi\.PRG\.Classes\.AD\_Miejscowosc](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.classes.ad_miejscowosc 'DiGi\.PRG\.Classes\.AD\_Miejscowosc')

The locality the point refers to, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when its reference does not resolve\.

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.PunktAdresowy(DiGi.PRG.Classes.AD_PunktAdresowy,DiGi.PRG.Classes.AD_Miejscowosc,DiGi.PRG.Classes.AD_UlicaPlac,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance).aD_UlicaPlac'></a>

`aD_UlicaPlac` [DiGi\.PRG\.Classes\.AD\_UlicaPlac](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.classes.ad_ulicaplac 'DiGi\.PRG\.Classes\.AD\_UlicaPlac')

The street the point refers to, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for a village address or when its reference does not resolve\.

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.PunktAdresowy(DiGi.PRG.Classes.AD_PunktAdresowy,DiGi.PRG.Classes.AD_Miejscowosc,DiGi.PRG.Classes.AD_UlicaPlac,DiGi.Geometry.Visual.Core.Interfaces.IPointAppearance).pointAppearance'></a>

`pointAppearance` [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.ipointappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IPointAppearance')

The point appearance of the object\.
### Properties

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.AD_Miejscowosc'></a>

## PunktAdresowy\.AD\_Miejscowosc Property

Gets a clone of the locality the point refers to\.

```csharp
public DiGi.PRG.Classes.AD_Miejscowosc? AD_Miejscowosc { get; }
```

#### Property Value
[DiGi\.PRG\.Classes\.AD\_Miejscowosc](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.classes.ad_miejscowosc 'DiGi\.PRG\.Classes\.AD\_Miejscowosc')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.AD_PunktAdresowy'></a>

## PunktAdresowy\.AD\_PunktAdresowy Property

Gets a clone of the address point\.

```csharp
public DiGi.PRG.Classes.AD_PunktAdresowy? AD_PunktAdresowy { get; }
```

#### Property Value
[DiGi\.PRG\.Classes\.AD\_PunktAdresowy](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.classes.ad_punktadresowy 'DiGi\.PRG\.Classes\.AD\_PunktAdresowy')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.AD_UlicaPlac'></a>

## PunktAdresowy\.AD\_UlicaPlac Property

Gets a clone of the street the point refers to, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for a village address\.

```csharp
public DiGi.PRG.Classes.AD_UlicaPlac? AD_UlicaPlac { get; }
```

#### Property Value
[DiGi\.PRG\.Classes\.AD\_UlicaPlac](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.classes.ad_ulicaplac 'DiGi\.PRG\.Classes\.AD\_UlicaPlac')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.identyfikatorSIMC'></a>

## PunktAdresowy\.identyfikatorSIMC Property

Gets the TERYT SIMC identifier of the locality\.

```csharp
public string? identyfikatorSIMC { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.identyfikatorULIC'></a>

## PunktAdresowy\.identyfikatorULIC Property

Gets the TERYT ULIC identifier of the street, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for a village address\.

```csharp
public string? identyfikatorULIC { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.kodPocztowy'></a>

## PunktAdresowy\.kodPocztowy Property

Gets the postal code\.

```csharp
public string? kodPocztowy { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.lokalnyId'></a>

## PunktAdresowy\.lokalnyId Property

Gets the local identifier of the address point\.

```csharp
public string? lokalnyId { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.miejscowoscNazwa'></a>

## PunktAdresowy\.miejscowoscNazwa Property

Gets the name of the locality\.

```csharp
public string? miejscowoscNazwa { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.miejscowoscRodzaj'></a>

## PunktAdresowy\.miejscowoscRodzaj Property

Gets the kind of the locality\.

```csharp
public System.Nullable<DiGi.PRG.Enums.AD_RodzajMiejscowosci> miejscowoscRodzaj { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.PRG\.Enums\.AD\_RodzajMiejscowosci](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.enums.ad_rodzajmiejscowosci 'DiGi\.PRG\.Enums\.AD\_RodzajMiejscowosci')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.numerPorzadkowy'></a>

## PunktAdresowy\.numerPorzadkowy Property

Gets the house number, e\.g\. `6A` or `2/4`\.

```csharp
public string? numerPorzadkowy { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.TERYTGminy'></a>

## PunktAdresowy\.TERYTGminy Property

Gets the seven\-digit TERYT code of the municipality the locality lies in\.

```csharp
public string? TERYTGminy { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.ulicaNazwaPelna'></a>

## PunktAdresowy\.ulicaNazwaPelna Property

Gets the full name of the street, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for a village address\.

```csharp
public string? ulicaNazwaPelna { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.ulicaRodzaj'></a>

## PunktAdresowy\.ulicaRodzaj Property

Gets the kind of the street, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for a village address\.

```csharp
public System.Nullable<DiGi.PRG.Enums.AD_RodzajObiektu> ulicaRodzaj { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.PRG\.Enums\.AD\_RodzajObiektu](https://learn.microsoft.com/en-us/dotnet/api/digi.prg.enums.ad_rodzajobiektu 'DiGi\.PRG\.Enums\.AD\_RodzajObiektu')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.PRG.Geometry.Classes.PunktAdresowy.wersjaId'></a>

## PunktAdresowy\.wersjaId Property

Gets the version identifier of the address point\.

```csharp
public System.Nullable<System.DateTimeOffset> wersjaId { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')