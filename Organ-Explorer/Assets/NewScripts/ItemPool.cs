﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPool : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
       // IDropHandler.objectDragging.transform.SetParent(transform);
    }
}
