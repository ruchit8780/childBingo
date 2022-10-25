using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Drag : MonoBehaviour
{
    [SerializeField]

    private Canvas canvas;
    public GameObject fruit;

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
             pointerData.position,
            canvas.worldCamera,
            out position);

        transform.position = canvas.transform.TransformPoint(position);
        Debug.Log(transform.position);
        if(transform.position.x>1700 && transform.position.x<1850 && transform.position.y>300 && transform.position.y < 350)
        {
            fruit.SetActive(false);
        }
    }
}