using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float Xsens = 1f;
    public float Ysens = 1f;
    private Rigidbody body;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movement();
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            body.linearVelocity = new Vector3(body.linearVelocity.x, body.linearVelocity.y, moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            body.linearVelocity = new Vector3(body.linearVelocity.x, body.linearVelocity.y, -1 * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            body.linearVelocity = new Vector3(-1 * moveSpeed, body.linearVelocity.y, body.linearVelocity.z);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            body.linearVelocity = new Vector3(moveSpeed, body.linearVelocity.y, body.linearVelocity.z);
        }
    }
}