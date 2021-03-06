// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Xunit.Performance;

namespace System.Runtime.Tests
{
    public class Perf_Object
    {
        [Benchmark]
        public void ctor()
        {
            foreach (var iteration in Benchmark.Iterations)
                using (iteration.StartMeasurement())
                    for (int i = 0; i < 10000; i++)
                    {
                        new object(); new object(); new object();
                        new object(); new object(); new object();
                        new object(); new object(); new object();
                    }
        }

        [Benchmark]
        public void GetType_()
        {
            object obj = new object();
            foreach (var iteration in Benchmark.Iterations)
                using (iteration.StartMeasurement())
                    for (int i = 0; i < 10000; i++)
                    {
                        obj.GetType(); obj.GetType(); obj.GetType();
                        obj.GetType(); obj.GetType(); obj.GetType();
                        obj.GetType(); obj.GetType(); obj.GetType();
                    }
        }
    }
}
