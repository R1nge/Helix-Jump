using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float forceY;
    private Rigidbody _rigidbody;
    private float _velocityBeforeCollision;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _velocityBeforeCollision = _rigidbody.velocity.magnitude;
    }

    public float GetVelocity()
    {
        return _velocityBeforeCollision;
    }

    public void AddForce()
    {
        _rigidbody.AddForce(0, forceY, 0, ForceMode.Impulse);
    }
}