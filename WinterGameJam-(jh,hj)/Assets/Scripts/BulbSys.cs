using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbSys : MonoBehaviour
{
    public static BulbSys bulbinstance;
    public GameObject turnonEffect;
    [SerializeField] GameObject cleartxt;
    private void Awake()
    {
        bulbinstance = this;
    }
    public void BecomeTrue()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("on");
        turnonEffect.SetActive(true);
    }
    private void Update()
    {
        if (GameSystem.instance.ranking.activeInHierarchy)
        {
            Invoke("LightOnoff", 1f);
            Invoke("Changetoclear", 2f);
        }
    }
    void LightOnoff()
    {
        cleartxt.SetActive(true);
        turnonEffect.SetActive(false);
        turnonEffect.SetActive(true);
        Invoke("LightOnoff", 1);
    }
    void Changetoclear()
    {
        GameSystem.instance.StageSelect();
    }
}
