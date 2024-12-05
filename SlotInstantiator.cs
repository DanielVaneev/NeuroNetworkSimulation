using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotInstantiator : MonoBehaviour
{
    [SerializeField] private SlotListStorage _slotStorage;
    private void Start()
    {
        _slotStorage.slots.Clear();
    }
    public void CreateInstance(Slot prefab, Transform parent)
    {
        Slot instance = Instantiate(prefab, parent);
        instance.gameObject.SetActive(true);
        _slotStorage.slots.Add(instance);
    }

}


