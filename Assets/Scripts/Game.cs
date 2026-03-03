using UnityEngine;

public class GAme : MonoBehaviour
{
    public UI Ui;
    public CanvasGroup StartMenuCanvasGroup;

    private static bool hasGameStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ui.ShowStartScreen();
    }

    public void OnStartButtonClick()
    {
        Ui.HideStartScreen();
        hasGameStarted = true;
    }

    public static bool IsGameStarted()
    {
        return hasGameStarted;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
