using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class representing a single player character
/// </summary>
public class Character : ScriptableObject
{
    /// <summary>
    /// The name of the character
    /// </summary>
    public string CharacterName { get; set; }
    
    /// <summary>
    /// List of any character classes used by this character
    /// </summary>
    public List<CharacterClass> Class { get; set; }
    
    /// <summary>
    /// List of all non-class related features used by this character (Ex. unarmed strike, sprint, object interaction, etc)
    /// </summary>
    public List<Feature> Features { get; set; }
    
    /// <summary>
    /// List of all stats used by this character
    /// </summary>
    public List<Stat> Stats { get; set; }
    
    /// <summary>
    /// List of all active stat modifiers being applied to this character
    /// </summary>
    public List<Stat> Modifiers { get; set; }

    /// <summary>
    /// Creates a new character from scratch using this character as a template
    /// </summary>
    public void CreateNew()
    {

    }

    /// <summary>
    /// Resets all of this character's stats to their base values
    /// </summary>
    public void Reset()
    {
        
    }
}
