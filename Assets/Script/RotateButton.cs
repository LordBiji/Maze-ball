using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateButton : EventTrigger
{
    [SerializeField] private Transform frameTrans;
    public override void OnPointerDown(PointerEventData eventData)
    {
        frameTrans.Rotate(0, 0, -5);
    }
    public override void OnPointerUp(PointerEventData eventData) 
    {
        frameTrans.Rotate(0, 0, 0); 
    }
}
