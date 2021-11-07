using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Scr_SelectChildren : MonoBehaviour
{
    //public void OnSelect(BaseEventData eventData) 
    //{
    //    foreach(Transform child in transform)
    //    {
    //        EventSystem.current.SetSelectedGameObject(gameObject);
    //    }
    //}

    public void ISelectHandler()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
