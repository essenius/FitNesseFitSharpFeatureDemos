﻿// Copyright 2015-2024 Rik Essenius
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System.Diagnostics.CodeAnalysis;

namespace TestSlim;

public class MethodAndProperty
{
    private static int _privateData = 123;

    public static int Data { get; set; } = 321;

    public static int GetData() => _privateData;
    public static void SetData(int value) => _privateData = value;
}