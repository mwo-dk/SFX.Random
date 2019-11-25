# SFX.Random
Helper methods for utilizing [RNGCryptoServiceProvider](https://referencesource.microsoft.com/#mscorlib/system/security/cryptography/rngcryptoserviceprovider.cs,d525bf7d9ca1d38a) as a randomizer. Two libraries are supported:

* [SFX.Random](https://www.nuget.org/packages/SFX.Random/) - is an F# library, which depends upon
* [SFX.Random.CSharp](https://www.nuget.org/packages/SFX.Random.CSharp/)

Basically the libraries just support functions for generating primitive types: bool, sbyte, char, short, int,
long, byte, ushort, uint, ulong, float, double, decimal, TimeSpan and DateTimeOffset.

Also functions for generating them in ranges are supported.
