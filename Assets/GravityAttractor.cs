using UnityEngine;

public class GravityAttractor : MonoBehaviour
{
    public float G = 0.1f;

    public void Attract(Transform body, float bodyMass)
    {
        Rigidbody rb = body.GetComponent<Rigidbody>();

        Vector3 direction = transform.position - body.position;
        float distance = direction.magnitude;

        float forceMagnitude = G * (bodyMass) / (distance * distance);

        Vector3 force = direction.normalized * forceMagnitude;

        rb.AddForce(force);
    }
}