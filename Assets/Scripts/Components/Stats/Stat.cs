using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour, IComponent
{
    public string Name { get; set; }
    public string ShortName { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }
    public int BaseValue { get; set; }

    public void SetValue(int value) 
    { 
        Value = value;
    }
}
