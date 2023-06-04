using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An <see cref="Actopm"/> that has a lasting effect that can be turned on or off (Ex. A spell that increases move speed while active)
/// </summary>
public class ToggleAction : Action
{
    /// <summary>
    /// Whether or not the <see cref="ToggleAction"/> is currently active
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// Sets the <see cref="Active"/> status of the <see cref="ToggleAction"/>
    /// </summary>
    /// <param name="value">The value to set <see cref="Active"/> to</param>
    public void Set(bool value)
    {
        Active = value;
    }
}
