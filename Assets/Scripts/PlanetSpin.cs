using UnityEngine;

public class PlanetSpin : MonoBehaviour
{
    public float rotationRate = 0.05f;

    void Update()
    {
        transform.Rotate(Vector3.down, rotationRate) ;
    }
}
