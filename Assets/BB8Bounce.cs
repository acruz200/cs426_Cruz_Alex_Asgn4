using UnityEngine;

public class BB8Bounce : MonoBehaviour
{
    public float bounceForce = 20f; 

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FireHydrant"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
            }
        }
    }
}
