﻿using System;

namespace X
{
    [AttributeUsage(AttributeTargets.Struct)]
    internal class NonCopyableAttribute : Attribute { }
}

[X.NonCopyable]
struct Counter
{
    private int _i;
    public void Count() => ++_i;
    public int Value => _i;
}

class Class1
{
    private readonly Counter _c;
}
