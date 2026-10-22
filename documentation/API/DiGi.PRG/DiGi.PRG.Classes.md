#### [DiGi\.PRG](DiGi.PRG.Overview.md 'DiGi\.PRG\.Overview')

## DiGi\.PRG\.Classes Namespace
### Classes

<a name='DiGi.PRG.Classes.AD_IdentyfikatorIIP'></a>

## AD\_IdentyfikatorIIP Class

Spatial information infrastructure \(IIP\) identifier of a PRG object \(`AD_IdentyfikatorIIP`\)\.

```csharp
public class AD_IdentyfikatorIIP : DiGi.GML.Classes.GML
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → AD\_IdentyfikatorIIP
### Constructors

<a name='DiGi.PRG.Classes.AD_IdentyfikatorIIP.AD_IdentyfikatorIIP()'></a>

## AD\_IdentyfikatorIIP\(\) Constructor

Initializes a new instance of the [AD\_IdentyfikatorIIP](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_IdentyfikatorIIP 'DiGi\.PRG\.Classes\.AD\_IdentyfikatorIIP') class\.

```csharp
public AD_IdentyfikatorIIP();
```
### Properties

<a name='DiGi.PRG.Classes.AD_IdentyfikatorIIP.lokalnyId'></a>

## AD\_IdentyfikatorIIP\.lokalnyId Property

Gets or sets the local identifier given by the data provider, unique in [przestrzenNazw](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_IdentyfikatorIIP.przestrzenNazw 'DiGi\.PRG\.Classes\.AD\_IdentyfikatorIIP\.przestrzenNazw')\.

```csharp
public string lokalnyId { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_IdentyfikatorIIP.przestrzenNazw'></a>

## AD\_IdentyfikatorIIP\.przestrzenNazw Property

Gets or sets the namespace of the data set the object comes from, e\.g\. `PL.PZGIK.200`\.

```csharp
public string przestrzenNazw { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_IdentyfikatorIIP.wersjaId'></a>

## AD\_IdentyfikatorIIP\.wersjaId Property

Gets or sets the version identifier of the object\.

An `xs:dateTime` written with an offset (`2024-11-21T19:10:44+02:00`). It is a [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') so the offset survives, which a [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') would convert into the local time of the machine.

```csharp
public System.Nullable<System.DateTimeOffset> wersjaId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.PRG.Classes.AD_Miejscowosc'></a>

## AD\_Miejscowosc Class

Locality of the PRG address register \(`AD_Miejscowosc`\): a town, a village or a part of one, as registered in TERYT SIMC\.

```csharp
public class AD_Miejscowosc : DiGi.PRG.Classes.AD_OgolnyObiekt
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [AD\_OgolnyObiekt](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_OgolnyObiekt 'DiGi\.PRG\.Classes\.AD\_OgolnyObiekt') → AD\_Miejscowosc
### Constructors

<a name='DiGi.PRG.Classes.AD_Miejscowosc.AD_Miejscowosc()'></a>

## AD\_Miejscowosc\(\) Constructor

Initializes a new instance of the [AD\_Miejscowosc](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_Miejscowosc 'DiGi\.PRG\.Classes\.AD\_Miejscowosc') class\.

```csharp
public AD_Miejscowosc();
```
### Properties

<a name='DiGi.PRG.Classes.AD_Miejscowosc.adres1'></a>

## AD\_Miejscowosc\.adres1 Property

Gets or sets the references \(`xlink:href`, `#gml:id`\) to the address points of the locality, the reverse of [miejscowosc](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_PunktAdresowy.miejscowosc 'DiGi\.PRG\.Classes\.AD\_PunktAdresowy\.miejscowosc')\. Optional in the schema; absent from every file of the 21\.10\.2026 package\.

```csharp
public System.Collections.Generic.List<string>? adres1 { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.PRG.Classes.AD_Miejscowosc.georeferencja'></a>

## AD\_Miejscowosc\.georeferencja Property

Gets or sets the reference point of the locality\. Its `gml:pos` is northing\-first; see `DiGi.PRG.Geometry.Convert.ToDiGi(Point?)`\.

```csharp
public DiGi.GML.Classes.Point? georeferencja { get; set; }
```

#### Property Value
[DiGi\.GML\.Classes\.Point](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.point 'DiGi\.GML\.Classes\.Point')

<a name='DiGi.PRG.Classes.AD_Miejscowosc.identyfikatorPRNG'></a>

## AD\_Miejscowosc\.identyfikatorPRNG Property

Gets or sets the identifier in the national register of geographical names \(PRNG\)\. Written empty in every file of the 21\.10\.2026 package\.

```csharp
public string? identyfikatorPRNG { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_Miejscowosc.identyfikatorSIMC'></a>

## AD\_Miejscowosc\.identyfikatorSIMC Property

Gets or sets the TERYT SIMC identifier of the locality\. A string, so leading zeros \(`0954047`\) survive\.

```csharp
public string identyfikatorSIMC { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_Miejscowosc.nazwa'></a>

## AD\_Miejscowosc\.nazwa Property

Gets or sets the name of the locality\.

```csharp
public string nazwa { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_Miejscowosc.nazwaJezykMniejszosci'></a>

## AD\_Miejscowosc\.nazwaJezykMniejszosci Property

Gets or sets the name in a minority language\. Optional in the schema; absent from every file of the 21\.10\.2026 package\.

```csharp
public string? nazwaJezykMniejszosci { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_Miejscowosc.rodzaj'></a>

## AD\_Miejscowosc\.rodzaj Property

Gets or sets the kind of locality, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when the code is not in [AD\_RodzajMiejscowosci](DiGi.PRG.Enums.md#DiGi.PRG.Enums.AD_RodzajMiejscowosci 'DiGi\.PRG\.Enums\.AD\_RodzajMiejscowosci')\.

```csharp
public System.Nullable<DiGi.PRG.Enums.AD_RodzajMiejscowosci> rodzaj { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[AD\_RodzajMiejscowosci](DiGi.PRG.Enums.md#DiGi.PRG.Enums.AD_RodzajMiejscowosci 'DiGi\.PRG\.Enums\.AD\_RodzajMiejscowosci')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.PRG.Classes.AD_Miejscowosc.TERYTGminy'></a>

## AD\_Miejscowosc\.TERYTGminy Property

Gets or sets the seven\-digit TERYT code of the municipality \(`gmina`\) the locality lies in, e\.g\. `0262011`\.

```csharp
public string TERYTGminy { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_Miejscowosc.ulica1'></a>

## AD\_Miejscowosc\.ulica1 Property

Gets or sets the references \(`xlink:href`, `#gml:id`\) to the streets of the locality, the reverse of [miejsce](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_UlicaPlac.miejsce 'DiGi\.PRG\.Classes\.AD\_UlicaPlac\.miejsce')\. Optional in the schema; absent from every file of the 21\.10\.2026 package\.

```csharp
public System.Collections.Generic.List<string>? ulica1 { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.PRG.Classes.AD_OgolnyObiekt'></a>

## AD\_OgolnyObiekt Class

Base class of every PRG address feature \(`AD_OgolnyObiekt`\): its identifier and the lifespan of its version\.

```csharp
public abstract class AD_OgolnyObiekt : DiGi.GML.Classes.GML, DiGi.PRG.Interfaces.IAD_OgolnyObiekt, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → AD\_OgolnyObiekt

Derived  
↳ [AD\_Miejscowosc](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_Miejscowosc 'DiGi\.PRG\.Classes\.AD\_Miejscowosc')  
↳ [AD\_PunktAdresowy](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_PunktAdresowy 'DiGi\.PRG\.Classes\.AD\_PunktAdresowy')  
↳ [AD\_UlicaPlac](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_UlicaPlac 'DiGi\.PRG\.Classes\.AD\_UlicaPlac')

Implements [IAD\_OgolnyObiekt](DiGi.PRG.Interfaces.md#DiGi.PRG.Interfaces.IAD_OgolnyObiekt 'DiGi\.PRG\.Interfaces\.IAD\_OgolnyObiekt'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Constructors

<a name='DiGi.PRG.Classes.AD_OgolnyObiekt.AD_OgolnyObiekt()'></a>

## AD\_OgolnyObiekt\(\) Constructor

Initializes a new instance of the [AD\_OgolnyObiekt](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_OgolnyObiekt 'DiGi\.PRG\.Classes\.AD\_OgolnyObiekt') class\.

```csharp
public AD_OgolnyObiekt();
```
### Properties

<a name='DiGi.PRG.Classes.AD_OgolnyObiekt.idIIP'></a>

## AD\_OgolnyObiekt\.idIIP Property

Gets or sets the spatial information infrastructure identifier of the object\.

```csharp
public DiGi.PRG.Classes.AD_IdentyfikatorIIP? idIIP { get; set; }
```

#### Property Value
[AD\_IdentyfikatorIIP](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_IdentyfikatorIIP 'DiGi\.PRG\.Classes\.AD\_IdentyfikatorIIP')

<a name='DiGi.PRG.Classes.AD_OgolnyObiekt.koniecWersjiObiektu'></a>

## AD\_OgolnyObiekt\.koniecWersjiObiektu Property

Gets or sets the end of the object version\. Optional in the schema; absent from every file of the 21\.10\.2026 package\.

```csharp
public System.Nullable<System.DateTime> koniecWersjiObiektu { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.PRG.Classes.AD_OgolnyObiekt.poczatekWersjiObiektu'></a>

## AD\_OgolnyObiekt\.poczatekWersjiObiektu Property

Gets or sets the start of the object version\.

The files write it without an offset (`2017-04-07T15:13:07`), so it is a [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime'): a [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') would invent the offset of the machine that parses it.

```csharp
public System.Nullable<System.DateTime> poczatekWersjiObiektu { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.PRG.Classes.AD_PunktAdresowy'></a>

## AD\_PunktAdresowy Class

Address point of the PRG address register \(`AD_PunktAdresowy`\)\.

The point does not carry its street or locality inline: [miejscowosc](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_PunktAdresowy.miejscowosc 'DiGi\.PRG\.Classes\.AD\_PunktAdresowy\.miejscowosc') and [ulica2](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_PunktAdresowy.ulica2 'DiGi\.PRG\.Classes\.AD\_PunktAdresowy\.ulica2') are references to an [AD\_Miejscowosc](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_Miejscowosc 'DiGi\.PRG\.Classes\.AD\_Miejscowosc') and an [AD\_UlicaPlac](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_UlicaPlac 'DiGi\.PRG\.Classes\.AD\_UlicaPlac') of the same file, resolved by `DiGi.PRG.Geometry.Create.PunktyAdresowe`.

```csharp
public class AD_PunktAdresowy : DiGi.PRG.Classes.AD_OgolnyObiekt
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [AD\_OgolnyObiekt](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_OgolnyObiekt 'DiGi\.PRG\.Classes\.AD\_OgolnyObiekt') → AD\_PunktAdresowy
### Constructors

<a name='DiGi.PRG.Classes.AD_PunktAdresowy.AD_PunktAdresowy()'></a>

## AD\_PunktAdresowy\(\) Constructor

Initializes a new instance of the [AD\_PunktAdresowy](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_PunktAdresowy 'DiGi\.PRG\.Classes\.AD\_PunktAdresowy') class\.

```csharp
public AD_PunktAdresowy();
```
### Properties

<a name='DiGi.PRG.Classes.AD_PunktAdresowy.dataNadania'></a>

## AD\_PunktAdresowy\.dataNadania Property

Gets or sets the date the number was assigned, when recorded\.

```csharp
public System.Nullable<System.DateTime> dataNadania { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.PRG.Classes.AD_PunktAdresowy.georeferencja'></a>

## AD\_PunktAdresowy\.georeferencja Property

Gets or sets the position of the point, usually near the entrance of the building\. Its `gml:pos` is northing\-first; see `DiGi.PRG.Geometry.Convert.ToDiGi(Point?)`\.

```csharp
public DiGi.GML.Classes.Point? georeferencja { get; set; }
```

#### Property Value
[DiGi\.GML\.Classes\.Point](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.point 'DiGi\.GML\.Classes\.Point')

<a name='DiGi.PRG.Classes.AD_PunktAdresowy.kodPocztowy'></a>

## AD\_PunktAdresowy\.kodPocztowy Property

Gets or sets the postal code, e\.g\. `59-220`\.

```csharp
public string? kodPocztowy { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_PunktAdresowy.miejscowosc'></a>

## AD\_PunktAdresowy\.miejscowosc Property

Gets or sets the reference \(`xlink:href`, `#gml:id`\) to the locality of the point\. Always present\.

```csharp
public string? miejscowosc { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_PunktAdresowy.numerPorzadkowy'></a>

## AD\_PunktAdresowy\.numerPorzadkowy Property

Gets or sets the house number\. Free text: `12`, `6A`, `2/4`, `13/17a`, `9-9`\.

```csharp
public string numerPorzadkowy { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_PunktAdresowy.ulica2'></a>

## AD\_PunktAdresowy\.ulica2 Property

Gets or sets the reference \(`xlink:href`, `#gml:id`\) to the street or square of the point, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for an address numbered within the locality only \(a village address\)\.

```csharp
public string? ulica2 { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_UlicaPlac'></a>

## AD\_UlicaPlac Class

Street or square of the PRG address register \(`AD_UlicaPlac`\), as registered in TERYT ULIC\.

The `geometria` element (a `gml:LineString`, `gml:MultiCurve`, `gml:Polygon` or `gml:MultiSurface`) is deliberately not modelled: DiGi.GML has no multi-geometry types, and the binder reads only declared properties, so leaving it out skips it safely. The council resolution references (`uchwala`) are left out as well; no file of the 21.10.2026 package carries one.

```csharp
public class AD_UlicaPlac : DiGi.PRG.Classes.AD_OgolnyObiekt
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [AD\_OgolnyObiekt](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_OgolnyObiekt 'DiGi\.PRG\.Classes\.AD\_OgolnyObiekt') → AD\_UlicaPlac
### Constructors

<a name='DiGi.PRG.Classes.AD_UlicaPlac.AD_UlicaPlac()'></a>

## AD\_UlicaPlac\(\) Constructor

Initializes a new instance of the [AD\_UlicaPlac](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_UlicaPlac 'DiGi\.PRG\.Classes\.AD\_UlicaPlac') class\.

```csharp
public AD_UlicaPlac();
```
### Properties

<a name='DiGi.PRG.Classes.AD_UlicaPlac.adres2'></a>

## AD\_UlicaPlac\.adres2 Property

Gets or sets the references \(`xlink:href`, `#gml:id`\) to the address points on the street, the reverse of [ulica2](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_PunktAdresowy.ulica2 'DiGi\.PRG\.Classes\.AD\_PunktAdresowy\.ulica2')\.

```csharp
public System.Collections.Generic.List<string>? adres2 { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.PRG.Classes.AD_UlicaPlac.identyfikatorULIC'></a>

## AD\_UlicaPlac\.identyfikatorULIC Property

Gets or sets the TERYT ULIC street identifier\. A string, so leading zeros \(`03513`\) survive; matches `OT_SKJZ_L.identyfikatorULIC` of BDOT10k\.

```csharp
public string? identyfikatorULIC { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_UlicaPlac.miejsce'></a>

## AD\_UlicaPlac\.miejsce Property

Gets or sets the references \(`xlink:href`, `#gml:id`\) to the localities the street lies in\.

```csharp
public System.Collections.Generic.List<string>? miejsce { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.PRG.Classes.AD_UlicaPlac.nazwaJezykMniejszosci'></a>

## AD\_UlicaPlac\.nazwaJezykMniejszosci Property

Gets or sets the name in a minority language\. Optional in the schema; absent from every file of the 21\.10\.2026 package\.

```csharp
public string? nazwaJezykMniejszosci { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_UlicaPlac.nazwaPelna'></a>

## AD\_UlicaPlac\.nazwaPelna Property

Gets or sets the full name as adopted by the municipal council, e\.g\. `Słowiański` or `Plac Henryka Pobożnego`\.

```csharp
public string nazwaPelna { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_UlicaPlac.rodzaj'></a>

## AD\_UlicaPlac\.rodzaj Property

Gets or sets the kind of object, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when the code is not in [AD\_RodzajObiektu](DiGi.PRG.Enums.md#DiGi.PRG.Enums.AD_RodzajObiektu 'DiGi\.PRG\.Enums\.AD\_RodzajObiektu')\.

The schema has no TERYT feature (`ul.`, `pl.`); this code replaces it.

```csharp
public System.Nullable<DiGi.PRG.Enums.AD_RodzajObiektu> rodzaj { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[AD\_RodzajObiektu](DiGi.PRG.Enums.md#DiGi.PRG.Enums.AD_RodzajObiektu 'DiGi\.PRG\.Enums\.AD\_RodzajObiektu')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.PRG.Classes.AD_UlicaPlac.TERYTNazwa1'></a>

## AD\_UlicaPlac\.TERYTNazwa1 Property

Gets or sets the part of the TERYT name that orders the street alphabetically\.

```csharp
public string TERYTNazwa1 { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.PRG.Classes.AD_UlicaPlac.TERYTNazwa2'></a>

## AD\_UlicaPlac\.TERYTNazwa2 Property

Gets or sets the remaining part of the TERYT name\. When present, the full TERYT name is [TERYTNazwa2](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_UlicaPlac.TERYTNazwa2 'DiGi\.PRG\.Classes\.AD\_UlicaPlac\.TERYTNazwa2') followed by [TERYTNazwa1](DiGi.PRG.Classes.md#DiGi.PRG.Classes.AD_UlicaPlac.TERYTNazwa1 'DiGi\.PRG\.Classes\.AD\_UlicaPlac\.TERYTNazwa1')\.

```csharp
public string? TERYTNazwa2 { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')