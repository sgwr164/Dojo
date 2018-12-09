﻿module FizzBuzzTest

open FizzBuzz
open NUnit.Framework

[<TestCase(1, "1")>]
[<TestCase(2, "2")>]
[<TestCase(3, "Fizz")>]
[<TestCase(4, "4")>]
[<TestCase(5, "Buzz")>]
[<TestCase(6, "Fizz")>]
[<TestCase(7, "7")>]
[<TestCase(8, "8")>]
[<TestCase(9, "Fizz")>]
[<TestCase(10, "Buzz")>]
[<TestCase(11, "11")>]
[<TestCase(12, "Fizz")>]
[<TestCase(13, "13")>]
[<TestCase(14, "14")>]
[<TestCase(15, "FizzBuzz")>]
let fizzbuzzTest(n: int, expected: string) :unit =
    Assert.AreEqual(fizzbuzz(n), expected)