using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A resource attached to a <see cref="Feature"/> that can be consumed (Ex. Spell slots, Ki points, Sorcery points, etc.)
/// </summary>
public class Consumable : IComponent
{
    /// <summary>
    /// The name of this <see cref="Consumable"/>
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// A description of the <see cref="Consumable"/> and how it is used
    /// </summary>
    public string Description { get; set; }
    public string ShortDescription { get; set; }
    
    /// <summary>
    /// The total number of uses of the <see cref="Consumable"/>
    /// </summary>
    public int Total { get; set; }
    
    /// <summary>
    /// The current remaining number of uses of the <see cref="Consumable"/>
    /// </summary>
    public int Current { get; set; }

    /// <summary>
    /// Removes a given number of uses of the <see cref="Consumable"/>
    /// </summary>
    /// <param name="value">The number of uses to consume</param>
    public void Consume(int value)
    {
        Current -= value;
    }
}
