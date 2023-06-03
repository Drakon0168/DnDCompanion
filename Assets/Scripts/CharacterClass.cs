using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class representing the character classes available to players
/// </summary>
[System.Serializable]
public class CharacterClass
{
    /// <summary>
    /// The user facing name of this <see cref="CharacterClass"/> (Wizard, Rogue, Fighter etc.)
    /// </summary>
    public string ClassName { get; set; }
    
    /// <summary>
    /// Description of the <see cref="CharacterClass"/>, flavor text
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// List of the class <see cref="Feature"/> of the <see cref="CharacterClass"/>
    /// </summary>
    public List<Feature> Features { get; set; }
    
    /// <summary>
    /// The <see cref="GameSystem"/> that this <see cref="CharacterClass"/> is used in
    /// </summary>
    public GameSystem System { get; set; }
}