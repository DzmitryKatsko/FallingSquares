using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScreen: MonoBehaviour
{
    [SerializeField]
    private ScoreController _scoreController;

    [SerializeField]
    private TextMeshProUGUI _currentScoreLabel;


    private void OnEnable()
    {
        _currentScoreLabel.text = _scoreController.GetCurrentScore().ToString();
    }
}
