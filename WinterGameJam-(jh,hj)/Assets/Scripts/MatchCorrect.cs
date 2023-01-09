using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchCorrect : MonoBehaviour
{
    GameSystem instance;
    string[] unit = { "AND", "OR","NOT" ,"NAND", "NOR", "XOR", "XNOR" };
    public int unitnum;
    private void Awake()
    {
        instance = GameSystem.instance;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!instance.dragging)
        {
            Checking(collision);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!instance.dragging)
        {
            Checking(collision);
        }
    }
    void Checking(Collision2D collision)
    {
        instance.Matchcorrecta = this.unit[unitnum];
        
    }
}
