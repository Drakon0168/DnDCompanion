using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A <see cref="Stat"/> used to override another <see cref="Stat"/> (Ex. In DnD a Monk's Unarmored AC overriding the base system's Unarmored AC)
/// </summary>
public class ReplacementStat : CalculatedStat
{
    /// <summary>
    /// The short name of the <see cref="Stat"/> to replace with this <see cref="ReplacementStat"/>
    /// </summary>
    public string TargetStat { get; set; }
}
