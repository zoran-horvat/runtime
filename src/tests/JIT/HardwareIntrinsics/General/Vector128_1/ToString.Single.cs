// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/******************************************************************************
 * This file is auto-generated from a template file by the GenerateTests.csx  *
 * script in tests\src\JIT\HardwareIntrinsics\General\Shared. In order to make    *
 * changes, please update the corresponding template and run according to the *
 * directions listed in the file.                                             *
 ******************************************************************************/

using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using Xunit;

namespace JIT.HardwareIntrinsics.General._Vector128_1
{
    public static partial class Program
    {
        [Fact]
        public unsafe static void ToStringSingle()
        {
            int size = Unsafe.SizeOf<Vector128<Single>>() / sizeof(Single);
            Single[] values = new Single[size];

            for (int i = 0; i < size; i++)
            {
                values[i] = TestLibrary.Generator.GetSingle();
            }
            
            Vector128<Single> vector = Vector128.Create(values[0], values[1], values[2], values[3]);
            string actual = vector.ToString();

            string expected = '<' + string.Join(", ", values.Select(x => x.ToString("G", System.Globalization.CultureInfo.InvariantCulture))) + '>';

            bool succeeded = string.Equals(expected, actual, StringComparison.Ordinal);

            if (!succeeded)
            {
                TestLibrary.TestFramework.LogInformation($"Vector128SingleToString: Vector128<Single>.ToString() returned an unexpected result.");
                TestLibrary.TestFramework.LogInformation($"Expected: {expected}");
                TestLibrary.TestFramework.LogInformation($"Actual: {actual}");
                TestLibrary.TestFramework.LogInformation(string.Empty);

                throw new Exception("One or more scenarios did not complete as expected.");
            }
        }
    }
}
