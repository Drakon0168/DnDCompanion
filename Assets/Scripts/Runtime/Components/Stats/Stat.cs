using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A base stat that is not calculated based on any other stats
/// </summary>
public class Stat : IComponent
{
    /// <summary>
    /// User facing name of the <see cref="Stat"/> (Ex. Dexterity)
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Shortened name of the <see cref="Stat"/>, also used to reference this stat in stat calculations and <see cref="Feature"/>
    /// This name should be unique and not shared by any other stat (Ex. DEX)
    /// </summary>
    public string ShortName { get; set; }
    
    /// <summary>
    /// Description of the <see cref="Stat"/> and what it does in the game
    /// </summary>
    public string Description { get; set; }
    public string ShortDescription { get; set; }
    
    /// <summary>
    /// The current value of the <see cref="Stat"/> after any <see cref="StatModifier"/> or external changes are applied (Ex. Current Health)
    /// </summary>
    public int Value { get; set; }
    
    /// <summary>
    /// The base value of the <see cref="Stat"/> regardless of any <see cref="StatModifier"/> (Ex. Max Health)
    /// </summary>
    public int BaseValue { get; set; }

    public void SetValue(int value) 
    { 
        Value = value;
    }
}
