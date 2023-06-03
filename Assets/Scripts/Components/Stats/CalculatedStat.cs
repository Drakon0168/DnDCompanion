using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A <see cref="Stat"/> whose value is calculated based on other stats (Ex. )
/// </summary>
public class CalculatedStat : Stat
{
    /// <summary>
    /// The formula used to calculate this <see cref="CalculatedStat"/>, other <see cref="Stat"/> should be referenced by their <see cref="Stat.ShortName"/>.
    /// For example in DnD your Intelligence Modifier would have a formula of "(INT - 10) / 2" where
    /// INT is the short name of the Intelligence Stat
    /// </summary>
    public string Formula { get; set; }
}
