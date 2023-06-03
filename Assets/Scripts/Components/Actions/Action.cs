using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour, IComponent
{
    public string Name { get; set; }
    public string Description { get; set; }

    public void Perform() 
    { 

    }
}
