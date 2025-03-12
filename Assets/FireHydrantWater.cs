using UnityEngine;

public class FireHydrantWater : MonoBehaviour
{
    public ParticleSystem waterSpray; 
    private bool isSpraying = false; 

    void Start()
    {
        if (waterSpray != null)
            waterSpray.Stop(); 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BB8") && !isSpraying)
        {
            if (waterSpray != null)
            {
                waterSpray.Play(); 
                isSpraying = true; 
            }
        }
    }
}
