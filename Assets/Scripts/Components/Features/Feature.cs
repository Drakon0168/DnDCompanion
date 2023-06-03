using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feature : MonoBehaviour, IComponent
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ShortDescription { get; set; }
    public List<IComponentBase> Components { get; set; }
    public bool Locked { get; set; }
    public int UnlockValue { get; set; }
    public string LockStat { get; set; }
}
