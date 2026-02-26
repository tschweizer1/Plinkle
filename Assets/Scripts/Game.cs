using UnityEngine;

public class GAme : MonoBehaviour
{
    public CanvasGroup StartMenuCanvasGroup;

    private static bool hasGameStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
    }

    public void OnStartButtonClick()
    {
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
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
