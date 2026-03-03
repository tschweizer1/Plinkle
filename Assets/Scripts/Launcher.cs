using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform projectileSpawn;
    public void Launch(Vector2 aimDirection)
    {
        GameObject projectileObject = Instantiate(projectilePrefab, projectileSpawn.position, Quaternion.identity);

        LaunchProjectile(projectileObject, aimDirection);
    }

    private void LaunchProjectile(GameObject projectileObject, Vector2 aimDirection)
    {
        Rigidbody2D projectileRigidbody = projectileObject.GetComponent<Rigidbody2D>();
        
        projectileRigidbody.AddForce(aimDirection * 5f, ForceMode2D.Impulse);
        
    }
}
