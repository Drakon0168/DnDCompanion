using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A special <see cref="FeatureOption"/> that will automatically share the same
/// <see cref="FeatureOption.Selection"/> as its linked <see cref="FeatureOption"/>
/// </summary>
public class LinkedFeatureOption : FeatureOption
{
    /// <summary>
    /// The <see cref="FeatureOption"/> that this <see cref="LinkedFeatureOption"/>
    /// will get its <see cref="FeatureOption.Selection"/> from
    /// </summary>
    public FeatureOption Link { get; set; }

    public override int Selection => Link.Selection;
}