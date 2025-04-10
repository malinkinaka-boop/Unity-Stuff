using UnityEngine;

public class Ball : MonoBehaviour
{
    public float thrust = 1.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * thrust);
    }

    void FixedUpdate()
    {
        // Уберите этот код, чтобы сила больше не применялась
    }
}

