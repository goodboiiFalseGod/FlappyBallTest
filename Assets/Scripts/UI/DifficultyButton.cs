using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void ChangeButtonText(string newText)
    {
        _text.text = newText;
    }
}
