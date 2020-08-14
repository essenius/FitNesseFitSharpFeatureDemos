// Copyright 2015-2020 Rik Essenius
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

namespace TestSlim
{
    [SuppressMessage("Code Quality", "IDE0051:Remove unused private members", Justification = "Demonstration of FitSharp functionality")]
    public class NamingConventions
    {
        private static object _privateStaticField;
        internal static object InternalStaticField;

        [SuppressMessage("Microsoft.Usage", "CA2211:NonConstantFieldsShouldNotBeVisible", Justification = "Demonstration of FitSharp functionality")]
        public static object PublicStaticField;

        private object _privateField;
        internal object InternalField;

        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Justification = "Demonstration of FitSharp functionality")]
        public object PublicField;

        internal static object InternalStaticProperty { get; set; }
        private static object PrivateStaticProperty { get; set; }
        public static object PublicStaticProperty { get; set; }

        internal object InternalProperty { get; set; }
        private object PrivateProperty { get; set; }
        public object PublicProperty { get; set; }

        internal static object InternalStaticMethod() => InternalStaticField;
        private static object PrivateStaticMethod() => _privateStaticField;
        public static object PublicStaticMethod() => PublicStaticField;

        internal static void InternalStaticMethod(object value) => InternalStaticField = value;
        private static void PrivateStaticMethod(object value) => _privateStaticField = value;
        public static void PublicStaticMethod(object value) => PublicStaticField = value;

        internal object InternalMethod() => InternalField;
        private object PrivateMethod() => _privateField;

        public object PublicMethod() => PublicField;
        internal void InternalMethod(object value) => InternalField = value;
        private void PrivateMethod(object value) => _privateField = value;
        public void PublicMethod(object value) => PublicField = value;
    }
}