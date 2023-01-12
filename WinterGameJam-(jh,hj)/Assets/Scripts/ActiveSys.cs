using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSys : MonoBehaviour
{
    [SerializeField] List<GameObject> ActiveThing;
    public bool UpdateEnable;
    public void OneActive() => ActiveThing[0].SetActive(!ActiveThing[0].activeInHierarchy);
    public void TwoActive() 
    {
        ActiveThing[0].SetActive(!ActiveThing[0].activeInHierarchy);
        ActiveThing[1].SetActive(!ActiveThing[1].activeInHierarchy); 
    }
    private void Update()
    {
        if (UpdateEnable)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if(ActiveThing.Count == 1)
                {
                    OneActive();
                }
                else
                TwoActive();
            }
        }
    }
}
