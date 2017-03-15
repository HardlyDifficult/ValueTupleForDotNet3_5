// HD: Original Source: https://github.com/dotnet/corefx/blob/8f824ba00f5656436f7063da49fb0ac94eff8566/src/Common/src/System/Numerics/Hashing/HashHelpers.cs
// HD: No modifications made

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Numerics.Hashing
{
  internal static class HashHelpers
  {
    public static readonly int RandomSeed = Guid.NewGuid().GetHashCode();

    public static int Combine(int h1, int h2)
    {
      unchecked
      {
        // RyuJIT optimizes this to use the ROL instruction
        // Related GitHub pull request: dotnet/coreclr#1830
        uint rol5 = ((uint)h1 << 5) | ((uint)h1 >> 27);
        return ((int)rol5 + h1) ^ h2;
      }
    }
  }
}