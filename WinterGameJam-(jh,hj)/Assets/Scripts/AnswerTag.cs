using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerTag : MonoBehaviour
{
    public bool AND=false;
    public bool OR=false;
    public bool NOT=false;
    public bool NAND=false;
    public bool NOR=false;
    public bool XOR=false;
    public bool XNOR=false;
    public bool Return(string name)
    {
        return name switch
        {
            "AND" => AND,
            "OR" => OR,
            "NOT"=>NOT,
            "NAND" => NAND,
            "NOR" => NOR,
            "XOR" => XOR,
            "XNOR" => XNOR,
            _ => false
        };
    }
}
