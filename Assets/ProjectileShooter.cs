using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    [Header("Projectile Settings")]
    public GameObject projectilePrefab; 
    public Transform shootPoint; 
    public float shootForce = 15f; 
    public float projectileLifetime = 5f; // Destroy after time

    [Header("Shooting Controls")]
    public KeyCode shootKey = KeyCode.Mouse0; // Left Mouse Button

    void Update()
    {
        if (Input.GetKeyDown(shootKey))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (projectilePrefab != null && shootPoint != null)
        {
           
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

            
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);
            }

    
            Destroy(projectile, projectileLifetime);
        }
        else
        {
            Debug.LogWarning("Projectile prefab or shoot point is missing!");
        }
    }
}
