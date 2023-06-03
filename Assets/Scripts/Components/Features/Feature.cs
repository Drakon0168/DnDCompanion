using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A feature of a <see cref="Character"/> or <see cref="CharacterClass"/>. These are the selections used to add functionality to a character or class
/// </summary>
public class Feature : IComponent
{
    // <summary>
    /// The name of the <see cref="Feature"/>
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// A description of the <see cref="Feature"/> and what it does, flavor text
    /// </summary>
    public string Description { get; set; }
    public string ShortDescription { get; set; }
    
    /// <summary>
    /// The <see cref="IComponent"/>s that make up the <see cref="Feature"/>, these are used to set the actual functionality
    /// </summary>
    public List<IComponentBase> Components { get; set; }
    
    /// <summary>
    /// Whether or not this <see cref="Feature"/> is locked behind a <see cref="Stat"/>
    /// </summary>
    public bool Locked { get; set; }
    
    /// <summary>
    /// The value that the <see cref="LockStat"/> must reach to unlock a locked <see cref="Feature"/>
    /// </summary>
    public int UnlockValue { get; set; }
    
    /// <summary>
    /// The short name of the <see cref="Stat"/> that this <see cref="Feature"/> is locked behind if it is a locked feature
    /// </summary>
    public string LockStat { get; set; }
}
