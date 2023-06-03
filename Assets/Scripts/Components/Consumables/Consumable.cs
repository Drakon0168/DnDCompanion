using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour, IComponent
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ShortDescription { get; set; }
    public int Total { get; set; }
    public int Current { get; set; }

    public void Consume() 
    { 

    }
}
