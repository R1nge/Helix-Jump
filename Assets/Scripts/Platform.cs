using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float velocityToDestroy;

    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.TryGetComponent(out PlayerMovementController playerMovement)) return;

        if (playerMovement.GetVelocity() > velocityToDestroy)
        {
            Destroy(gameObject);
        }

        playerMovement.AddForce();
    }
}