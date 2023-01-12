using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance;
    public bool dragging;
    [SerializeField] GameObject correctParticle;
    [SerializeField] GameObject incorrectParticle;
    public float time=0;
    public bool ispause=false;
    [SerializeField] GameObject cameramove;
    public int correct=0;
    public GameObject[] maps;
    //List<int> distinct;
    public GameObject normal, pause, ranking;
    public float limittime=4;
    public bool timeset=false;
    [SerializeField] List<GameObject> ActiveMaps;
    [SerializeField] GameObject Stageselect;
    //[SerializeField] GameObject[] transitions;
    //[SerializeField] GameObject Light;
    //int leftSprites;
    private void Awake()
    {
        instance = this;
            normal.SetActive(true);
            pause.SetActive(false);
            ranking.SetActive(false);
    }
    private void Update()
    {
        ispause = pause.activeInHierarchy;
        if (!ispause)
        {
            time+=Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Escape)&&!Stageselect.activeInHierarchy)
        {
            ispause = true;
            normal.SetActive(false);
            pause.SetActive(true);
        }
            //float mousex = Input.GetAxis("Horizontal");
            //float mousey = Input.GetAxis("Vertical");
            //cameramove.transform.position += new Vector3(mousex, mousey, 0);
        //if(leftSprites == 0)
        //{
        //    Test();
        //    leftSprites++;
        //}
    }
    public void SetSprite(GameObject map,string ttag)
    {
        map.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(ttag);
        correct++;
        //else
        //    cameramove.transform.position = maps[Distinct(Random.Range(0, maps.Length))].transform.position;
        //= new Vector3(cameramove.transform.localScale.x+correct, cameramove.transform.localScale.y + correct, cameramove.transform.localScale.z + correct);
    }
    //int Distinct(int rand)
    //{
    //    int count = distinct.Count;
    //    distinct[distinct.Count] = rand;
    //    distinct.Distinct();
    //    if(count == distinct.Count)
    //    {
    //        return Distinct(Random.Range(0, maps.Length));
    //    }
    //    else
    //    {
    //        Debug.Log($"{rand}, {count}");
    //        return rand;
    //    }
    //}
    public void Ranking()
    { 
        ranking.SetActive(true);
        normal.SetActive(false);
        pause.SetActive(false);
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
    public void SetActive(int stagenum)
    {
        if(stagenum <= ActiveMaps.Count)
        {
            ActiveMaps[stagenum].SetActive(!ActiveMaps[stagenum]);
        }
    }
    public void StageSelect()
    {
        Stageselect.SetActive(true) ;
        ranking.SetActive(false) ;
    }
}
