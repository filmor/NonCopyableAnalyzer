﻿using System;

[AttributeUsage(AttributeTargets.Struct)]
internal class NonCopyableAttribute : Attribute { }

[NonCopyable]
struct Counter
{
    private int _i;
    public void Count() => ++_i;
    public int Value => _i;
}

class Class1
{
    private Counter _c;
    Counter C1 => _c;
    Counter C2 { get { return _c; } }
    Counter C3 { get; set; }
    Counter C4 { get => _c; }
}
