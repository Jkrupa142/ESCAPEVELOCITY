using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlanetMovement : MonoBehaviour
{
    public float moveSpeed;
    public Transform planet;

    private Rigidbody rb;
    private Vector3 inputDir;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
        float turn = Input.GetAxis("Horizontal");  // A/D = orbit
        float move = Input.GetAxis("Vertical");    // W/S = forward/backward

        if (turn != 0)
        {
            Vector3 up = (transform.position - planet.position).normalized;
            transform.RotateAround(transform.position, up, turn * 100f * Time.deltaTime);
        }

        Vector3 upDir = (transform.position - planet.position).normalized;
        Vector3 forward = Vector3.ProjectOnPlane(transform.forward, upDir).normalized;

        inputDir = forward * move;
    }

    void FixedUpdate()
    {
        Vector3 up = (transform.position - planet.position).normalized;

        Quaternion targetRotation = Quaternion.FromToRotation(transform.up, up) * transform.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);

        rb.MovePosition(rb.position + inputDir * moveSpeed * Time.fixedDeltaTime);
    }
}