module SFX.Random

open SFX.Random.CSharp

let getRandomBool = RandomHelpers.GetRandomBool
let getRandomSignedByte = RandomHelpers.GetRandomSignedByte
let getRandomChar = RandomHelpers.GetRandomChar
let getRandomShort = RandomHelpers.GetRandomShort
let getRandomInt = RandomHelpers.GetRandomInt
let getRandomLong = RandomHelpers.GetRandomLong
let getRandomByte = RandomHelpers.GetRandomByte
let getRandomUnsignedShort = RandomHelpers.GetRandomUnsignedShort
let getRandomUnsignedInt = RandomHelpers.GetRandomUnsignedInt
let getRandomUnsignedLong = RandomHelpers.GetRandomUnsignedLong
let getRandomFloat = RandomHelpers.GetRandomFloat
let getRandomDouble = RandomHelpers.GetRandomDouble
let getRandomDecimal = RandomHelpers.GetRandomDecimal
let getRandomTimeSpan = RandomHelpers.GetRandomTimeSpan
let getRandomDateTimeOffset = RandomHelpers.GetRandomDateTimeOffset

let getRandomSignedByteInRange a b = RandomHelpers.GetRandomSignedByteInRange(a, b)
let getRandomCharInRange a b = RandomHelpers.GetRandomCharInRange(a, b)

let getRandomShortInRange a b = RandomHelpers.GetRandomShortInRange(a, b)
let getRandomIntInRange a b = RandomHelpers.GetRandomIntInRange(a, b)
let getRandomLongInRange a b = RandomHelpers.GetRandomLongInRange(a, b)
let getRandomByteInRange a b = RandomHelpers.GetRandomByteInRange(a, b)
let getRandomUnsignedShortInRange a b = RandomHelpers.GetRandomUnsignedShortInRange(a, b)
let getRandomUnsignedIntInRange a b = RandomHelpers.GetRandomUnsignedIntInRange(a, b)
let getRandomUnsignedLongInRange a b = RandomHelpers.GetRandomUnsignedLongInRange(a, b)
let getRandomFloatInRange a b = RandomHelpers.GetRandomFloatInRange(a, b)
let getRandomDoubleInRange a b = RandomHelpers.GetRandomDoubleInRange(a, b)
let getRandomDecimalInRange a b = RandomHelpers.GetRandomDecimalInRange(a, b)
let getRandomTimeSpanInRange a b = RandomHelpers.GetRandomTimeSpanInRange(a, b)
let getRandomDateTimeOffsetInRange a b = RandomHelpers.GetRandomDateTimeOffsetInRange(a, b)