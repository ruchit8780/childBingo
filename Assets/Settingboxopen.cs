using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Settingboxopen : MonoBehaviour,IPointerClickHandler
{
    
    
    public Slider volume;
    
     public void OnPointerClick(PointerEventData pointerEventData)
    {
        volume.interactable=true;
      
    }    
}
