using UnityEngine;

public class PlatformKiller : MonoBehaviour
{
    [SerializeField] private float velocityToDestroy;

    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.TryGetComponent(out PlayerMovementController playerMovement)) return;
        Destroy(playerMovement.GetVelocity() > velocityToDestroy ? gameObject : other.gameObject);
        playerMovement.AddForce();
    }
}