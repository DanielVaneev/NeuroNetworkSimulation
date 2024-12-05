using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [FormerlySerializedAs("neuronCount")] [FormerlySerializedAs("_neuronAmount")] [SerializeField] int _neuronCount;
    [SerializeField] private Image _background;

    public void SetNeuronAmount(string stringValue)
    {
        _neuronCount = String.IsNullOrEmpty(stringValue) ? 0 : Convert.ToInt32(stringValue);
    }

    public void SetColor(Color color)
    {
        _background.color = color;
    }
    public int neuronCount => _neuronCount;
}
