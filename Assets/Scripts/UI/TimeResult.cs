using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class TimeResult : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private TimeRecords _records;

    [Inject]
    private void Construct(TimeRecords timeRecords)
    {
        _records = timeRecords;
        _text.text = _records.GetLevelTtme().ToString() + " seconds";
    }
}
