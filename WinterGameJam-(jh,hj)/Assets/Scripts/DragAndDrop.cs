using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour//,IBeginDragHandler,IDragHandler,IEndDragHandler,IPointerDownHandler
{
    //[SerializeField] private Canvas canvas;
    //private RectTransform rectTransform;
    //RectTransform startrectTransform;
    //private void Awake()
    //{      
    //    rectTransform = GetComponent<RectTransform>();
    //    startrectTransform = rectTransform;
    //}
    //public void OnBeginDrag(PointerEventData eventData)
    //{
    //    //try
    //    //{
    //    //    throw new System.NotImplementedException();
    //    //}
    //    //catch (UnityException e)
    //    //{
    //    //    Debug.Log(e);
    //    //}
    //}

    //public void OnDrag(PointerEventData eventData)
    //{
    //    GameSystem.instance.dragging = true;
    //    //this.transform.position += new Vector3(eventData.delta.x, eventData.delta.y);
    //    rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    //}

    //public void OnEndDrag(PointerEventData eventData)
    //{
    //    try
    //    {
    //        GameSystem.instance.dragging = false;
    //        //throw new System.NotImplementedException();
    //    }
    //    catch(UnityException e)
    //    {
    //        Debug.Log(e);
    //    }
    //}

    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    try
    //    {
    //        //throw new System.NotImplementedException();
    //    }
    //    catch (UnityException e)
    //    {
    //        Debug.Log(e);
    //    }
    //}
    //public void ResetPos()
    //{
    //    this.rectTransform = startrectTransform;
    //}
    bool moving;
    Vector3 resetPosition;
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
        if(!moving)
        Checker(collision);
    }
    void Checker(Collision2D other)
    {
        //this.transform.localPosition = resetPosition;
        //other.gameObject.tag = this.gameObject.tag;
        //GameSystem.instance.SetSprite(other.gameObject);
        if (other.gameObject.tag == this.gameObject.tag)
        {
            this.transform.localPosition = resetPosition;
            GameSystem.instance.SetSprite(other.gameObject);
        }
        else
        {
            this.transform.localPosition = resetPosition;
        }
    } 
}
