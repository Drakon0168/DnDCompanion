using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public List<Stat> BaseStats { get; set; }
    public List<CalculatedStat> CalcStats { get; set; }
    public List<CharacterClass> Classes { get; set; }
}
