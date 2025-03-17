using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectable;  // Fixed placement of variable declaration

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null && controller.health < controller.maxHealth)
        {
            controller.PlaySound(collectable);
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}


