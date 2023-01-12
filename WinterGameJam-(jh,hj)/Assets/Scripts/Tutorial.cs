using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject tutorial, main;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            main.SetActive(true);
            tutorial.SetActive(false);
        }
    }
}
