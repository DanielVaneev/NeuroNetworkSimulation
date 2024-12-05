using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FirstLayerValidator : InputDataValidator
{
    protected override bool OverridableValidate()
    {
        if (_slots.slots.Count > 0)
        {
            return _slots.slots[0].neuronCount == _task.pixelCount;
        }
        else
        {
            print("Вы не создали слот!");
            return false;
        }
        
    }
}
