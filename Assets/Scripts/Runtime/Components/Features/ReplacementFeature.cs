using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A <see cref="Feature"/> that is used as an alternative to another <see cref="Feature"/> when selected.
/// </summary>
public class ReplacementFeature : Feature
{
    /// <summary>
    /// The <see cref="Feature"/> to replace with this feature
    /// </summary>
    public Feature TargetFeature { get; set; }
}
