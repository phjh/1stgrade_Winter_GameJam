using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchCorrectB : MonoBehaviour
{
    GameSystem instance;
    string[] unit = { "AND", "OR", "NOT", "NAND", "NOR", "XOR", "XNOR" };
    public int unitnum;
    private void Awake()
    {
        instance = GameSystem.instance;
        instance.Matchcorrectb = unit[unitnum];
    }
}
