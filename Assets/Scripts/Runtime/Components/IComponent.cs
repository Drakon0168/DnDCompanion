using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Interface used to control what can be added to a <see cref="Feature"/>
/// </summary>
public interface IComponent : IComponentBase
{
    /// <summary>
    /// The name of the <see cref="IComponent"/>
    /// </summary>
    string Name { get; }
    
    /// <summary>
    /// A description of the <see cref="IComponent"/>
    /// </summary>
    string Description { get; }
    
    /// <summary>
    /// A shortened description to be used when the full <see cref="Description"/> is not needed
    /// </summary>
    string ShortDescription { get; }
}
