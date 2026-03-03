using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text scoreText;
    public CanvasGroup StartMenuCanvasGroup;
    public CanvasGroup GuiCanvasGroup;

    public void ShowScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Hide(GuiCanvasGroup);
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
    }

    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Show(GuiCanvasGroup);
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
    }
}
