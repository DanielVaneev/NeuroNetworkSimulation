using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
public class TaskConditions : ScriptableObject
{
    [SerializeField] private int _dataset = 1000;
    [SerializeField, TextArea] private string _descriptionTemplate;
    [SerializeField] private Vector2Int _inputImageSize = new Vector2Int(28, 28);
    [SerializeField] private RangeInt _linkCountRangeModifiers = new (){min = 2, max = 5};
    [SerializeField] private int _maxLayerAmount = 4;
    [SerializeField] private RangeInt _outputNumbers = new (){min = 0, max = 9};
    public int dataset => _dataset;
    public int minOutputNumber => _outputNumbers.min;
    public int maxOutputNumber => _outputNumbers.max;
    public int outputNumberCount => maxOutputNumber - minOutputNumber + 1;
    public string descriptionTemplate => _descriptionTemplate;
    public int pixelCount => _inputImageSize.x * _inputImageSize.y;
    public int minRelationsNumber => _dataset / 5;
    public int maxRelationsNumber => _dataset / 2;
}
[Serializable]
public struct RangeInt
{
    public int min;
    public int max;
}
