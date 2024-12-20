// Copyright 2015-2024 Rik Essenius
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System;
using System.Globalization;

namespace TestSlim;

public class Temperature
{
    private const double AbsoluteZeroInCelsius = -273.15;
    private const double AbsoluteZeroInFahrenheit = -459.67;
    private const int PrecisionInDigits = 10;

    public Temperature(string input)
    {
        var scale = input?[^1..].ToUpperInvariant();
        var temperature = Convert.ToDouble(input?[..^1].Trim(), CultureInfo.InvariantCulture);
        Value = scale switch
        {
            "F" => Math.Round((temperature - AbsoluteZeroInFahrenheit) * 5 / 9, PrecisionInDigits),
            "C" => temperature - AbsoluteZeroInCelsius,
            "K" => temperature,
            _ => throw new FormatException("Expected a double, ending with F, C or K")
        };
    }

    public double Value { get; }
    public static Temperature Parse(string input) => new(input);
    public override string ToString() => $"Temperature: {Value} K";

    internal double ValueIn(string scale)
    {
        return scale?[..1].ToUpperInvariant() switch
        {
            "F" => Math.Round(Value * 9 / 5 + AbsoluteZeroInFahrenheit, PrecisionInDigits),
            "C" => Value + AbsoluteZeroInCelsius,
            "K" => Value,
            _ => throw new FormatException($"Unrecognized scale: {scale}")
        };
    }
}