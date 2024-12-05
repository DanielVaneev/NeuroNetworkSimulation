using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskConditionsView : MonoBehaviour
{
    [SerializeField] private TaskConditions _data;
    [SerializeField] private TextMeshProUGUI _textField;
    public void ViewData()
    {
        _textField.text = _data.descriptionTemplate;
        ReplaceParameterWithValue("dataset", _data.dataset);
        ReplaceParameterWithValue("minOutputNumber", _data.minOutputNumber);
        ReplaceParameterWithValue("maxOutputNumber", _data.maxOutputNumber);
    }

    private void ReplaceParameterWithValue(string parameter, int value)
    {
        _textField.text = _textField.text.Replace($"{{{parameter}}}", value.ToString());
    }
}
