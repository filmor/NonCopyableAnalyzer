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
    Counter C1 { get; set; }
    Counter C2 { set => _c = value; }
    Counter C3 { set { _c = value; } }
}
