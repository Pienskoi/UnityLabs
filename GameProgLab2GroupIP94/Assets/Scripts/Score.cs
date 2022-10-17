using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreTextMeshProUGUI;

    private int _score = 0;

    private void Awake()
    {
        scoreTextMeshProUGUI.text = $"Набрано балів: {_score}";
    }

    public void AddPoints(int value)
    {
        _score += value;
        scoreTextMeshProUGUI.text = $"Набрано балів: {_score}";
    }
}
