using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text scoreText;
    public CanvasGroup StartMenuCanvasGroup;

    public void ShowScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
    }

    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
    }
}
