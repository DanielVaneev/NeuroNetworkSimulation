using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputDataValidator : MonoBehaviour
{
    [SerializeField] protected SlotListStorage _slots;
    [SerializeField] protected TaskConditions _task;
    public bool Validate()
    {
        var result = OverridableValidate();
        print($"Проверка {GetType()}: {result}");
        return result;
    }

    protected abstract bool OverridableValidate();
}
