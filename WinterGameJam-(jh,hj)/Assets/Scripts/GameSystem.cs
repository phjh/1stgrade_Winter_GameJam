using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance;
    public bool dragging;
    public int Matchcorrecta;
    public int Matchcorrectb;
    [SerializeField] GameObject correctParticle;
    [SerializeField] GameObject incorrectParticle;
    public float time=0;
    public bool ispause=false;
    [SerializeField] 
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
    }
    public void EventCollsion()
    {
        if(Matchcorrecta == Matchcorrectb)
        {
            Instantiate(correctParticle);
        }
        else
        {
            Instantiate(incorrectParticle);
            
        }
    }
}
