using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Button _button;
    private DifficultyScreen _parenScreen;
    private GameDifficultySettings _gameDifficultySettings;

    public void ChangeSettings(GameDifficultySettings gameDifficultySettings, DifficultyScreen parentScreen)
    {
        _text.text = gameDifficultySettings.name;
        _gameDifficultySettings = gameDifficultySettings;
        _parenScreen = parentScreen;

        _button.onClick.AddListener(OnChangeClick);
    }

    private void OnChangeClick() => _parenScreen.OnButtonPressed(_gameDifficultySettings);
}
