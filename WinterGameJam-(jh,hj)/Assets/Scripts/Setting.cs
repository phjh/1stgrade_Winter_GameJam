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
    public List<GameObject> maps = new List<GameObject>();
    [SerializeField] Camera cam;
    [SerializeField] GameObject Stage;
    public void Compiler(bool value)
    {
        if (value)
        {
            int rand = Random.Range(0, mappos.Count);
            for (int i = 0; i < mappos.Count-1; i++)
            {
                maps[i].SetActive(false);
            }
            maps[rand].SetActive(true);
        }
        else
        {
            GameSystem.instance.Ranking();
        }
    }
    public void NRDCompiler(int mapposnum)
    {
        maps[mapposnum].SetActive(true);
        Stage.SetActive(false);
    }
}
