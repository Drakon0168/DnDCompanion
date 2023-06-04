using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An action that can be taken by a <see cref="Character"/> (Ex. Sprint, Attack, Spells etc)
/// </summary>
public class Action : IComponent
{
    /// <summary>
    /// The name of the <see cref="Action"/>
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// A description of the <see cref="Action"/>, what it does and when it can be used
    /// </summary>
    public string Description { get; set; }
    public string ShortDescription { get; set; }
    
    public void Perform() 
    { 

    }
}
