using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Will handle giving health to the character when they enter the trigger.
/// </summary>
namespace Final {

public class HealthCollectible : MonoBehaviour 
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
}