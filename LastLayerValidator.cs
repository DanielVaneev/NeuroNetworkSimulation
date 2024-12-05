using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LastLayerValidator : InputDataValidator
{
    protected override bool OverridableValidate()
    {
        if (_slots.slots.Count > 0)
        {
            var neuronCount= _slots.slots[^1].neuronCount;
            var targetNeuronCount = _task.outputNumberCount;
            return neuronCount == targetNeuronCount;
        }
        else
        {
            print("Вы не создали слот!");
            return false;
        }
        
    }
}
