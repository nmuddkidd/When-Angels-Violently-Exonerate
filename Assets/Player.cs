using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 nextmove = new Vector3(transform.position.x,transform.position.y,transform.position.z); 
        if (Input.GetKey(KeyCode.W))
        {
            nextmove.z  += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            nextmove.z -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            nextmove.x  += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            nextmove.x -= moveSpeed * Time.deltaTime;
        }
        transform.position = nextmove;
    }
}