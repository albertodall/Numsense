﻿module Ploeh.Numsense.ItalianExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                          "zero",          0)>]
[<InlineData(                                         " zero",          0)>]
[<InlineData(                                         "zero ",          0)>]
[<InlineData(                                      "  zero  ",          0)>]
[<InlineData(                                          "Zero",          0)>]
[<InlineData(                                          "ZERO",          0)>]
[<InlineData(                                       " zERo\t",          0)>]
[<InlineData(                                           "uno",          1)>]
[<InlineData(                                           "UNO",          1)>]
[<InlineData(                                           "due",          2)>]
[<InlineData(                                          " due",          2)>]
[<InlineData(                                           "tre",          3)>]
[<InlineData(                                        "tre   ",          3)>]
[<InlineData(                                       "quattro",          4)>]
[<InlineData(                                    "  quattro ",          4)>]
[<InlineData(                                        "cinque",          5)>]
[<InlineData(                                        "CinquE",          5)>]
[<InlineData(                                           "sei",          6)>]
[<InlineData(                                       "  SEI  ",          6)>]
[<InlineData(                                         "sette",          7)>]
[<InlineData(                                     "    sEtte",          7)>]
[<InlineData(                                          "otto",          8)>]
[<InlineData(                                          "oTTO",          8)>]
[<InlineData(                                          "nove",          9)>]
[<InlineData(                                        "NovE  ",          9)>]
[<InlineData(                                         "dieci",         10)>]
[<InlineData(                                        "undici",         11)>]
[<InlineData(                                        "dodici",         12)>]
[<InlineData(                                       "tredici",         13)>]
[<InlineData(                                   "quattordici",         14)>]
[<InlineData(                                      "quindici",         15)>]
[<InlineData(                                        "sedici",         16)>]
[<InlineData(                                   "diciassette",         17)>]
[<InlineData(                                      "diciotto",         18)>]
[<InlineData(                                    "diciannove",         19)>]
[<InlineData(                                         "venti",         20)>]
[<InlineData(                                       "ventuno",         21)>]
[<InlineData(                                      "ventidue",         22)>]
[<InlineData(                                        "trenta",         30)>]
[<InlineData(                                 "trentaquattro",         34)>]
[<InlineData(                                     "trentotto",         38)>]
[<InlineData(                                      "quaranta",         40)>]
[<InlineData(                                    "quarantuno",         41)>]
[<InlineData(                               "quarantaquattro",         44)>]
[<InlineData(                                     "cinquanta",         50)>]
[<InlineData(                                "cinquantasette",         57)>]
[<InlineData(                                      "sessanta",         60)>]
[<InlineData(                                "sessantacinque",         65)>]
[<InlineData(                                      "settanta",         70)>]
[<InlineData(                                 "settantasette",         77)>]
[<InlineData(                                  "settantanove",         79)>]
[<InlineData(                                       "ottanta",         80)>]
[<InlineData(                                    "ottantasei",         86)>]
[<InlineData(                                       "novanta",         90)>]
[<InlineData(                                    "novantatre",         93)>]
[<InlineData(                                         "cento",        100)>]
[<InlineData(                                      "centouno",        101)>]
[<InlineData(                                      "centodue",        102)>]
[<InlineData(                                  "centoventuno",        121)>]
[<InlineData(                                  "centoottanta",        180)>]
[<InlineData(                                   "centottanta",        180)>]
[<InlineData(                                      "duecento",        200)>]
[<InlineData(                            "duecentoottantadue",        282)>]
[<InlineData(                             "duecentottantadue",        282)>]
[<InlineData(                               "duecentoottanta",        280)>]
[<InlineData(                                "duecentottanta",        280)>]
[<InlineData(                           "duecentotrentasette",        237)>]
[<InlineData(                        "trecentosettantacinque",        375)>]
[<InlineData(                           "quattrocentonovanta",        490)>]
[<InlineData(                        "cinquecentosessantatre",        563)>]
[<InlineData(                              "seicentodiciotto",        618)>]
[<InlineData(                       "settecentosettantasette",        777)>]
[<InlineData(                               "ottocentocinque",        805)>]
[<InlineData(                                  "ottocentosei",        806)>]
[<InlineData(                                "ottocentosette",        807)>]
[<InlineData(                              "ottocentoottanta",        880)>]
[<InlineData(                               "ottocentottanta",        880)>]
[<InlineData(                           "ottocentoottantotto",        888)>]
[<InlineData(                            "ottocentottantotto",        888)>]
[<InlineData(                        "novecentocinquantanove",        959)>]
[<InlineData(                                         "mille",       1000)>]
[<InlineData(                                      "milleuno",       1001)>]
[<InlineData(                                      "milledue",       1002)>]
[<InlineData(                          "millesessantaquattro",       1064)>]
[<InlineData(                                       "duemila",       2000)>]
[<InlineData(                     "ottomilasettecentoventuno",       8721)>]
[<InlineData(                         "novemilacentoventitre",       9123)>]
[<InlineData(                                     "diecimila",      10000)>]
[<InlineData(                             "diecimilacentouno",      10101)>]
[<InlineData(                             "diecimilacentodue",      10102)>]
[<InlineData(                                    "undicimila",      11000)>]
[<InlineData(        "ventitremilacinquecentosessantaquattro",      23564)>]
[<InlineData(                              "ottantamiladieci",      80010)>]
[<InlineData(                                     "centomila",     100000)>]
[<InlineData(                                  "centomilauno",     100001)>]
[<InlineData(   "trecentodiciannovemila trecentoquarantanove",     319349)>]
[<InlineData(                                    "un milione",    1000000)>]
[<InlineData(                                "un milione uno",    1000001)>]
[<InlineData(                             "due milioni dieci",    2000010)>]
[<InlineData(                        "sei milioni trentamila",    6030000)>]
[<InlineData(   "nove milioni duecentounomilaseicentoottanta",    9201680)>]
[<InlineData(                                 "dieci milioni",   10000000)>]
[<InlineData(                            "dieci milioni nove",   10000009)>]
[<InlineData(                               "ventuno milioni",   21000000)>]
[<InlineData(                                                   
       "quarantasette milioni seicentosessantunomilasessanta",   47661060)>]
[<InlineData(                                 "cento milioni",  100000000)>]
[<InlineData(                        "duecentocinque milioni",  205000000)>]
[<InlineData(                         "trecentosette milioni",  307000000)>]
[<InlineData(                                                   
        "quattrocentosessantuno milioni sessantamilaseicento",  461060600)>]
[<InlineData(                                   "un miliardo", 1000000000)>]
[<InlineData(                             "un miliardo dieci", 1000000010)>]
[<InlineData(                     "un miliardo trentottomila", 1000038000)>]
[<InlineData(                        "un miliardo un milione", 1001000000)>]
[<InlineData(   "un miliardo un milione centomilasessantotto", 1001100068)>]
[<InlineData(                                  "due miliardi", 2000000000)>]
[<InlineData(
    "due miliardi quarantanove milioni seicentocinquantamila", 2049650000)>]
[<InlineData(
 "due miliardi centoquarantasette milioni quattrocentoottantatremilaseicentoquarantasette",
 System.Int32.MaxValue)>]
let ``tryParseItalian returns correct result`` (italian, expected) =
    let actual = Numeral.tryParseItalian italian
    Some expected =! actual

[<Theory>]
[<InlineData(          0, "zero")>]
[<InlineData(          1, "uno")>]
[<InlineData(          2, "due")>]
[<InlineData(          3, "tre")>]
[<InlineData(          4, "quattro")>]
[<InlineData(          5, "cinque")>]
[<InlineData(          6, "sei")>]
[<InlineData(          7, "sette")>]
[<InlineData(          8, "otto")>]
[<InlineData(          9, "nove")>]
[<InlineData(         10, "dieci")>]
[<InlineData(         11, "undici")>]
[<InlineData(         12, "dodici")>]
[<InlineData(         13, "tredici")>]
[<InlineData(         14, "quattordici")>]
[<InlineData(         15, "quindici")>]
[<InlineData(         16, "sedici")>]
[<InlineData(         17, "diciassette")>]
[<InlineData(         18, "diciotto")>]
[<InlineData(         19, "diciannove")>]
[<InlineData(         20, "venti")>]
[<InlineData(         21, "ventuno")>]
[<InlineData(         30, "trenta")>]
[<InlineData(         34, "trentaquattro")>]
[<InlineData(         40, "quaranta")>]
[<InlineData(         42, "quarantadue")>]
[<InlineData(         50, "cinquanta")>]
[<InlineData(         58, "cinquantotto")>]
[<InlineData(         60, "sessanta")>]
[<InlineData(         65, "sessantacinque")>]
[<InlineData(         70, "settanta")>]
[<InlineData(         79, "settantanove")>]
[<InlineData(         80, "ottanta")>]
[<InlineData(         86, "ottantasei")>]
[<InlineData(         90, "novanta")>]
[<InlineData(         93, "novantatre")>]
[<InlineData(        100, "cento")>]
[<InlineData(        101, "centouno")>]
[<InlineData(        102, "centodue")>]
[<InlineData(        110, "centodieci")>]
[<InlineData(        114, "centoquattordici")>]
[<InlineData(        121, "centoventuno")>]
[<InlineData(        135, "centotrentacinque")>]
[<InlineData(        180, "centoottanta")>]
[<InlineData(        200, "duecento")>]
[<InlineData(        282, "duecentoottantadue")>]
[<InlineData(        331, "trecentotrentuno")>]
[<InlineData(        407, "quattrocentosette")>]
[<InlineData(        520, "cinquecentoventi")>]
[<InlineData(        666, "seicentosessantasei")>]
[<InlineData(        798, "settecentonovantotto")>]
[<InlineData(        857, "ottocentocinquantasette")>]
[<InlineData(        880, "ottocentoottanta")>]
[<InlineData(        888, "ottocentoottantotto")>]
[<InlineData(        999, "novecentonovantanove")>]
[<InlineData(       1000, "mille")>]
[<InlineData(       1001, "milleuno")>]
[<InlineData(       1010, "milledieci")>]
[<InlineData(       1066, "millesessantasei")>]
[<InlineData(       1337, "milletrecentotrentasette")>]
[<InlineData(       1984, "millenovecentoottantaquattro")>]
[<InlineData(       2015, "duemilaquindici")>]
[<InlineData(       3000, "tremila")>]
[<InlineData(       3297, "tremiladuecentonovantasette")>]
[<InlineData(       4080, "quattromilaottanta")>]
[<InlineData(       5011, "cinquemilaundici")>]
[<InlineData(       6025, "seimilaventicinque")>]
[<InlineData(       7441, "settemilaquattrocentoquarantuno")>]
[<InlineData(       8513, "ottomilacinquecentotredici")>]
[<InlineData(       9000, "novemila")>]
[<InlineData(      10000, "diecimila")>]
[<InlineData(      11000, "undicimila")>]
[<InlineData(      12001, "dodicimilauno")>]
[<InlineData(      23456, "ventitremilaquattrocentocinquantasei")>]
[<InlineData(      32109, "trentaduemilacentonove")>]
[<InlineData(      40404, "quarantamilaquattrocentoquattro")>]
[<InlineData(      56789, "cinquantaseimilasettecentoottantanove")>]
[<InlineData(      60015, "sessantamilaquindici")>]
[<InlineData(      71003, "settantunomilatre")>]
[<InlineData(      80522, "ottantamilacinquecentoventidue")>]
[<InlineData(      98765, "novantottomilasettecentosessantacinque")>]
[<InlineData(     100000, "centomila")>]
[<InlineData(     100001, "centomilauno")>]
[<InlineData(     100010, "centomiladieci")>]
[<InlineData(     101010, "centounomiladieci")>]
[<InlineData(     200000, "duecentomila")>]
[<InlineData(     321000, "trecentoventunomila")>]
[<InlineData(     411416, "quattrocentoundicimilaquattrocentosedici")>]
[<InlineData(     530121, "cinquecentotrentamilacentoventuno")>]
[<InlineData(     600000, "seicentomila")>]
[<InlineData(     788000, "settecentoottantottomila")>]
[<InlineData(     876540, "ottocentosettantaseimilacinquecentoquaranta")>]
[<InlineData(     908077, "novecentoottomilasettantasette")>]
[<InlineData(    1000000, "un milione")>]
[<InlineData(    2000002, "due milioni due")>]
[<InlineData(    3040506, "tre milioni quarantamilacinquecentosei")>]
[<InlineData(    4321000, "quattro milioni trecentoventunomila")>]
[<InlineData(    5004621, "cinque milioni quattromilaseicentoventuno")>]
[<InlineData(    6982001, "sei milioni novecentoottantaduemilauno")>]
[<InlineData(    7000000, "sette milioni")>]
[<InlineData(    8000220, "otto milioni duecentoventi")>]
[<InlineData(    9099000, "nove milioni novantanovemila")>]
[<InlineData(   10000000, "dieci milioni")>]
[<InlineData(   24000000, "ventiquattro milioni")>]
[<InlineData(   39020011, "trentanove milioni ventimilaundici")>]
[<InlineData(   40606100, "quaranta milioni seicentoseimilacento")>]
[<InlineData(   53000000, "cinquantatre milioni")>]
[<InlineData(   64000098, "sessantaquattro milioni novantotto")>]
[<InlineData(   70003190, "settanta milioni tremilacentonovanta")>]
[<InlineData(   80000000, "ottanta milioni")>]
[<InlineData(   99000099, "novantanove milioni novantanove")>]
[<InlineData(  100000000, "cento milioni")>]
[<InlineData(  209000000, "duecentonove milioni")>]
[<InlineData(  398000000, "trecentonovantotto milioni")>]
[<InlineData(  439011000, "quattrocentotrentanove milioni undicimila")>]
[<InlineData(  560400000, "cinquecentosessanta milioni quattrocentomila")>]
[<InlineData(  600010900, "seicento milioni diecimilanovecento")>]
[<InlineData(  700000000, "settecento milioni")>]
[<InlineData(  800116000, "ottocento milioni centosedicimila")>]
[<InlineData(  900800007, "novecento milioni ottocentomilasette")>]
[<InlineData( 1000000000, "un miliardo")>]
[<InlineData( 1000000010, "un miliardo dieci")>]
[<InlineData( 1000038000, "un miliardo trentottomila")>]
[<InlineData( 1001000000, "un miliardo un milione")>]
[<InlineData( 1001100068, "un miliardo un milione centomilasessantotto")>]
[<InlineData( 2121000000, "due miliardi centoventuno milioni")>]
[<InlineData(
 System.Int32.MaxValue,
 "due miliardi centoquarantasette milioni quattrocentoottantatremilaseicentoquarantasette")>]
let ``toItalian returns correct result`` (i, expected) =
    let actual = Numeral.toItalian i
    expected =! actual
