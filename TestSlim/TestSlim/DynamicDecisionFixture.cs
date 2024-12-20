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
using System.Collections.Generic;
using System.Linq;

namespace TestSlim;

public class DynamicDecisionFixture
{
    private readonly List<string> _q1Months = ["JAN", "FEB", "MAR"];
    private readonly List<string> _q2Months = ["APR", "MAY", "JUN"];

    private readonly Dictionary<string, double> _totals = new()
    {
        {"Q1", 0.0},
        {"Q2", 0.0},
        {"TOTAL", 0.0}
    };

    public double Get(string columnName) => _totals[columnName.ToUpperInvariant()];

    public void Reset()
    {
        foreach (var key in _totals.Keys.ToList())
        {
            _totals[key] = 0.0;
        }
    }

    public void Set(string columnName, double value)
    {
        _totals["TOTAL"] += value;
        var month = columnName.ToUpperInvariant();
        if (_q1Months.Contains(month))
        {
            _totals["Q1"] += value;
            return;
        }
        if (!_q2Months.Contains(month))
        {
            throw new ArgumentException("Column name must be JAN-JUN");
        }
        _totals["Q2"] += value;
    }
}