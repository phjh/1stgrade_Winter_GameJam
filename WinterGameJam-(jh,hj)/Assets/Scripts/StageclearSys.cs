using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageclearSys : MonoBehaviour
{
    bool moving;
    Vector3 resetPosition;
    AnswerTag answer;
    [SerializeField] GameObject Clear;
    [SerializeField] GameObject cleartxt;
    //[SerializeField] List<GameObject> Answers;
    private void Start()
    {
        resetPosition = this.transform.localPosition;
    }
    private void Update()
    {
        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            moving = true;
        }
    }
    private void OnMouseUp()
    {
        moving = false;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!moving)
            Checker(collision);
    }
    void Checker()
    {
        this.transform.localPosition = resetPosition;
    }
    void Checker(Collision2D other)
    {
        //this.transform.localPosition = resetPosition;
        //other.gameObject.tag = this.gameObject.tag;
        //GameSystem.instance.SetSprite(other.gameObject);
        answer = other.gameObject.GetComponent<AnswerTag>();
        //if (Answers.Count == 1)
        {
            if (answer.Return(this.gameObject.tag))
            {
                this.transform.localPosition = resetPosition;
                BulbSys.bulbinstance.BecomeTrue();
                GameSystem.instance.SetSprite(other.gameObject, this.gameObject.tag);
                Clear.SetActive(true);
                cleartxt.SetActive(true);
            }
            else
            {
                this.transform.localPosition = resetPosition;
                //GameSystem.instance.Ranking();
                Debug.Log("incorrect");
            }
        }
        //answer = other.gameObject.GetComponent<AnswerTag>();
        //if (answer.Return(this.gameObject.tag))
        //{
        //    this.transform.localPosition = resetPosition;
        //    GameSystem.instance.correct++;
        //    GameSystem.instance.SetSprite(other.gameObject, this.gameObject.tag);
        //    BulbSys.bulbinstance.BecomeTrue();
        //    TimeLimit.tInstance.Correct();
        //}
        //else
        //{
        //    this.transform.localPosition = resetPosition;
        //    //GameSystem.instance.Ranking();
        //    Debug.Log("incorrect");
        //}
        //else if (Answers.Count == 2)
        //{
        //    bool ab = answer.Return(this.gameObject.tag);
        //    if (answer.Return(this.gameObject.tag))
        //    {
        //        this.transform.localPosition = resetPosition;
        //        BulbSys.bulbinstance.BecomeTrue();
        //        GameSystem.instance.SetSprite(other.gameObject, this.gameObject.tag);
        //        Clear.SetActive(true);
        //    }
        //    if (answer.Return(this.gameObject.tag))
        //    {
        //        this.transform.localPosition = resetPosition;
        //        BulbSys.bulbinstance.BecomeTrue();
        //        GameSystem.instance.SetSprite(other.gameObject, this.gameObject.tag);
        //        Clear.SetActive(true);
        //    }
        //    else
        //    {
        //        this.transform.localPosition = resetPosition;
        //        //GameSystem.instance.Ranking();
        //        Debug.Log("incorrect");
        //    }
        //}
    }
}
