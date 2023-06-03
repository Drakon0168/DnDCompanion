using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A <see cref="Consumable"/> that has it's <see cref="Consumable.Total"/> uses calculated by <see cref="Stat"/>s
/// </summary>
public class CalculatedConsumable : Consumable
{
    /// <summary>
    /// The formula used to calculate the <see cref="Consumable.Total"/> number of uses of the
    /// <see cref="CalculatedConsumable"/>, for example in DnD a Sorcerer's sorcery points would
    /// have the formula "SORCLVL" when the Sorcerer Level stat has a short name of "SORCLVL"
    /// </summary>
    public string Formula { get; set; }
}
