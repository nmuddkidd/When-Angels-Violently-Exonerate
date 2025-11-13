using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
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
        if (Input.GetKey(KeyCode.W)){
            body.linearVelocity = transform.forward * moveSpeed;
        }else if (Input.GetKey(KeyCode.S)){
            body.linearVelocity = transform.forward * -1 * moveSpeed;
        }
        if (Input.GetKey(KeyCode.A)){
            body.linearVelocity = transform.right * -1 * moveSpeed;
        }else if (Input.GetKey(KeyCode.D)){
            body.linearVelocity = transform.right * moveSpeed;
        }
    }
}