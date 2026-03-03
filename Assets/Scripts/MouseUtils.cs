using UnityEngine;
using UnityEngine.InputSystem;

public static class MouseUtils
{
    public static Vector3 GetMouseWorldPosition(Camera camera)
    {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = camera.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0f;
        
        return mouseWorld;
    }
}
