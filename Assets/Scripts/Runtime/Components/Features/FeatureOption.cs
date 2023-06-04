using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A <see cref="Feature"/> that has multiple options to choose between
/// </summary>
public class FeatureOption : Feature
{
    /// <summary>
    /// The index of the <see cref="Feature"/> that has been chosen in the <see cref="Options"/> list
    /// </summary>
    public virtual int Selection { get; set; }
    
    /// <summary>
    /// A list of the <see cref="Feature"/> that can be chosen when this <see cref="FeatureOption"/> is selected
    /// </summary>
    public List<Feature> Options { get; set;}
}
