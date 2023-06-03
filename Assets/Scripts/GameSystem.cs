using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class representing the overall game system to be used (Ex Dungeons and Dragons, Pathfinder, Honey Heist)
/// </summary>
public class GameSystem : ScriptableObject
{
    /// <summary>
    /// The name of the Game System
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Core stats of the game system that are shared by all characters (In DnD: Strength, Dexterity, Wisdom etc.)
    /// </summary>
    public List<Stat> BaseStats { get; set; }
    
    /// <summary>
    /// Core Calculated stats of the game system (In DnD: Armor Class, Initiative, Proficiency etc.)
    /// </summary>
    public List<CalculatedStat> CalcStats { get; set; }
    
    /// <summary>
    /// List of all of the different action types used in the system (In DnD: Action, Bonus Action, Reaction etc.)
    /// </summary>
    public List<string> ActionTypes { get; set; }
}