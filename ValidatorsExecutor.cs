using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidatorsExecutor : MonoBehaviour
{
    private InputDataValidator[] _validators;
    public bool[] results;

    private void Start()
    {
        _validators =  GetComponentsInChildren<InputDataValidator>();
    }

    public void Execute()
    {
        foreach (var validator in _validators)
        {
            validator.Validate();
        }
    }
}
