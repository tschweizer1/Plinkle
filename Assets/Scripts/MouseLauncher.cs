using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.WSA;

public class MouseLauncher : MonoBehaviour
{
    public Sounds sounds;
    public Launcher Launcher;
    // Update is called once per frame
    void Update()
    {
        if (!GAme.IsGameStarted())
        {
            return;
        }

        if (Mouse.current == null)
        {
            return;
        }

        if (Ball.IsBallInPlay())
        {
            return;
        }
        
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Launch();
        }
        
    }

    private void Launch()
    {
        Vector2 aimDirection = GetAimDirection();
        sounds.PlayCannonSound();
        Launcher.Launch(aimDirection);
        
    }

    private Vector2 GetAimDirection()
    {
        Vector3 mouseWorld = GetMouseWorldPosition();
        return (mouseWorld - transform.position).normalized;
    }
    
    private Vector3 GetMouseWorldPosition()
    {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0f;
        return mouseWorld;
    }
}
