using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circuit : MonoBehaviour
{
    string thisunit;
    [SerializeField] GameObject previous_Ag;
    [SerializeField] GameObject previous_Bg;
    public bool now;
    public bool setBase;
    public bool previous_A;
    public bool previous_B;
    bool And() => previous_A && previous_B;
    bool Or() => previous_A || previous_B;
    bool Nand() => !(previous_A && previous_B);
    bool Nor() => !(previous_A || previous_B);
    bool Xor() => previous_A != previous_B;
    bool Xnor() => !(previous_A != previous_B);

    public void Called()
    {
        thisunit = this.gameObject.tag;
        if (setBase == true)
        {
            Transgister();
        }
        else
        {
            now = setBase;
        }
    }
    void Transgister()
    {
        bool previous_A;
        bool previous_B;
        previous_A = previous_Ag.GetComponent<circuit>().now;
        previous_B = previous_Ag.GetComponent<circuit>().now;
        now = this.thisunit switch
        {
            "AND" => And(),
            "OR" => Or(),
            "NAND" => Nand(),
            "NOR" => Nor(),
            "XOR" => Xor(),
            "XNOR" => Xnor(),
            _ => false
        };
        Setting.mapSet.Compiler(now);
    }
}
