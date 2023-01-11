using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public static Setting mapSet;
    private void Awake()
    {
        mapSet = this;
    }
    public List<Transform> mappos = new List<Transform>();
    [SerializeField] Camera cam;
    public void Compiler(bool value)
    {
        if (value)
        {
            int rand = Random.Range(0, mappos.Count);
            cam.transform.position = mappos[rand].position;
            mappos.RemoveAt(rand);
        }
        else
        {
            GameSystem.instance.Ranking();
        }
    }
}
