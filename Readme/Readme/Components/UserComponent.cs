﻿using Entitas;
using Entitas.CodeGenerator.Attributes;

[Game, Unique]
public sealed class UserComponent : IComponent {

    public string name;
    public int age;
}
