using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public Transform planet;
    public float gravity = 3f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 direction = (planet.position - transform.position).normalized;
        rb.AddForce(direction * gravity, ForceMode.Acceleration);

        Quaternion targetRotation = Quaternion.FromToRotation(transform.up, -direction) * transform.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5f * Time.deltaTime);
    }
}