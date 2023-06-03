using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string CharacterName { get; set; }
    public List<CharacterClass> Class { get; set; }
    public List<Feature> Features { get; set; }
    public List<Stat> Stats { get; set; }
    public List<Stat> Modifiers { get; set; }

    public void CreateNew()
    {

    }

    public void Reset()
    {
        
    }
}
