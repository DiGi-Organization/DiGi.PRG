#### [DiGi\.PRG](DiGi.PRG.Overview.md 'DiGi\.PRG\.Overview')

## DiGi\.PRG\.Enums Namespace
### Enums

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci'></a>

## AD\_RodzajMiejscowosci Enum

Kind of locality in the PRG address schema \(code list `AD_RodzajMiejscowosciType`, the TERYT SIMC `RM` codes\)\.

The [System\.ComponentModel\.DescriptionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.descriptionattribute 'System\.ComponentModel\.DescriptionAttribute') holds the code written in the GML files. Member names follow the schema's `gml:description`, except [czescMiejscowosci](DiGi.PRG.Enums.md#DiGi.PRG.Enums.AD_RodzajMiejscowosci.czescMiejscowosci 'DiGi\.PRG\.Enums\.AD\_RodzajMiejscowosci\.czescMiejscowosci'), which the schema misspells `czescMiejcowosci`.

```csharp
public enum AD_RodzajMiejscowosci
```
### Fields

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.czescMiejscowosci'></a>

`czescMiejscowosci` 0

Part of a locality\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.wies'></a>

`wies` 1

Village\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.kolonia'></a>

`kolonia` 2

Colony\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.przysiolek'></a>

`przysiolek` 3

Hamlet\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.osada'></a>

`osada` 4

Settlement\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.osadaLesna'></a>

`osadaLesna` 5

Forest settlement\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.osiedle'></a>

`osiedle` 6

Housing estate\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.schroniskoTurystyczne'></a>

`schroniskoTurystyczne` 7

Mountain hostel\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.dzielnicaWarszawy'></a>

`dzielnicaWarszawy` 8

District of the capital city of Warsaw\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.miasto'></a>

`miasto` 9

Town or city\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.delegatura'></a>

`delegatura` 10

Delegation \(an administrative part of a city\)\.

<a name='DiGi.PRG.Enums.AD_RodzajMiejscowosci.czescMiasta'></a>

`czescMiasta` 11

Part of a town or city\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu'></a>

## AD\_RodzajObiektu Enum

Kind of street or square in the PRG address schema \(code list `AD_RodzajObiektuType`\)\.

The [System\.ComponentModel\.DescriptionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.descriptionattribute 'System\.ComponentModel\.DescriptionAttribute') holds the code written in the GML files; member names follow the schema's `gml:description`. The code records how the object was registered, not what its name says: Legnica's `Rynek` is [innyPowierzchniowy](DiGi.PRG.Enums.md#DiGi.PRG.Enums.AD_RodzajObiektu.innyPowierzchniowy 'DiGi\.PRG\.Enums\.AD\_RodzajObiektu\.innyPowierzchniowy'), not [rynek](DiGi.PRG.Enums.md#DiGi.PRG.Enums.AD_RodzajObiektu.rynek 'DiGi\.PRG\.Enums\.AD\_RodzajObiektu\.rynek').

```csharp
public enum AD_RodzajObiektu
```
### Fields

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.ulica'></a>

`ulica` 0

Street\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.aleja'></a>

`aleja` 1

Avenue\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.plac'></a>

`plac` 2

Square\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.skwer'></a>

`skwer` 3

Small green square\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.bulwar'></a>

`bulwar` 4

Boulevard\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.rondo'></a>

`rondo` 5

Roundabout\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.park'></a>

`park` 6

Park\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.rynek'></a>

`rynek` 7

Market square\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.szosa'></a>

`szosa` 8

Highway \(`szosa`\)\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.droga'></a>

`droga` 9

Road\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.osiedle'></a>

`osiedle` 10

Housing estate\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.ogrod'></a>

`ogrod` 11

Garden\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.wyspa'></a>

`wyspa` 12

Island\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.wybrzeze'></a>

`wybrzeze` 13

Waterfront\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.innyLiniowy'></a>

`innyLiniowy` 14

Other linear object\.

<a name='DiGi.PRG.Enums.AD_RodzajObiektu.innyPowierzchniowy'></a>

`innyPowierzchniowy` 15

Other areal object\.