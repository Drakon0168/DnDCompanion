using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IComponent : IComponentBase
{
    string Name { get; }
    string Description { get; }
}
