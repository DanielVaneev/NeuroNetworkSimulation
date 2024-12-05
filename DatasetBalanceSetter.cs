using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DatasetBalanceSetter : MonoBehaviour
{
    [SerializeField] private TaskConditions _taskConditions;
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _trainingAmountCaption;
    [SerializeField] private TextMeshProUGUI _testAmountCaption;
    
    void Start()
    {
        int dataset = _taskConditions.dataset;
        _slider.maxValue = dataset;
        _slider.value = Mathf.RoundToInt(dataset / 2);
    }

    public void SetBalance(float sliderValue)
    {
        _trainingAmountCaption.text = $"{sliderValue}";
        _testAmountCaption.text = $"{_slider.maxValue - sliderValue}";
        Debug.Log($"Метод работает! {Time.frameCount}");
    }
}
