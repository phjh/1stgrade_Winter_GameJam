using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSys : MonoBehaviour
{
    public int Stagenum;
    [SerializeField] GameObject mapbulb;
    [SerializeField] GameObject trangision;

    public void MapbtnClick() 
    { 
        Setting.mapSet.NRDCompiler(Stagenum);
        mapbulb.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("off");
        trangision.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("mapimage");
        mapbulb.GetComponent<BulbSys>().turnonEffect.SetActive(false);
    }   
}
