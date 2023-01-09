using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler,IPointerDownHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    RectTransform startrectTransform;
    private void Awake()
    {      
        rectTransform = GetComponent<RectTransform>();
        startrectTransform = rectTransform;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        GameSystem.instance.dragging = true;
        Debug.Log(GameSystem.instance.dragging);
        //this.transform.position += new Vector3(eventData.delta.x, eventData.delta.y);
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GameSystem.instance.dragging = false;
        Debug.Log(GameSystem.instance.dragging);
        throw new System.NotImplementedException();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
    public void ResetPos()
    {
        this.rectTransform = startrectTransform;
    }
}
