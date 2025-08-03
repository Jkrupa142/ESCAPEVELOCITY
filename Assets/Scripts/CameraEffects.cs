using UnityEngine;
using Unity.Cinemachine;
using Unity.VisualScripting;

public class CameraEffects : MonoBehaviour
{

    private CinemachineCamera cam;

    public Rigidbody playerRb;

    public float minFOV;
    public float minVelocity;

    public float maxFOV;
    public float maxVelocity;


    private void Start()
    {
        cam = GetComponent<CinemachineCamera>();
        if (cam == null) throw new MissingReferenceException("No Camera provided.");
    }

    private void Update()
    {
        if (playerRb != null && cam != null)
        {
            float t = Mathf.Clamp(playerRb.linearVelocity.magnitude, minFOV, maxFOV) / maxFOV;
            cam.Lens.FieldOfView = Mathf.Lerp(minFOV, maxFOV, t);

            Debug.Log (cam.Lens.FieldOfView + ": " + playerRb.linearVelocity.magnitude);
        }
    }

}
