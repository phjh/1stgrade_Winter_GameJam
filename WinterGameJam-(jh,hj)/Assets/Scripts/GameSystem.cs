using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance;
    public bool dragging;
    [SerializeField] GameObject correctParticle;
    [SerializeField] GameObject incorrectParticle;
    public float time=0;
    public bool ispause=false;
    [SerializeField] GameObject cameramove;
    int correct;
    //[SerializeField] GameObject[] transitions;
    //[SerializeField] GameObject Light;
    //int leftSprites;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (!ispause)
        {
            time+=Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ispause = true;
        }
            float mousex = Input.GetAxis("Horizontal");
            float mousey = Input.GetAxis("Vertical");
            cameramove.transform.position += new Vector3(mousex, mousey, 0);
        //if(leftSprites == 0)
        //{
        //    Test();
        //    leftSprites++;
        //}
    }
    public void SetSprite(GameObject map)
    {
        map.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(map.tag);
        //= new Vector3(cameramove.transform.localScale.x+correct, cameramove.transform.localScale.y + correct, cameramove.transform.localScale.z + correct);
    }
    //public void Test()
    //{
    //    for (int i = transitions.Length - correct-1; i <= transitions.Length; i++)
    //    {
    //        transitions[i].GetComponent<circuit>().Called();
    //    }
    //    if (transitions[transitions.Length].GetComponent<circuit>().now)
    //    {
    //        isLighting();
    //        Light.SetActive(true);
    //    }
    //}
    //public void isLighting()
    //{
    //    for (int i = transitions.Length - correct; i <= transitions.Length; i++)
    //    {
    //        transitions[i].GetComponent<circuit>().Called();
    //    }
    //    correct++;
    //    Camera cam = cameramove.GetComponent<Camera>();
    //    cam.DOOrthoSize(cam.orthographicSize, 1);
    //    Light.SetActive(false);
    //}
}
