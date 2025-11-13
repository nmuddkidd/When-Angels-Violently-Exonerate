using UnityEngine;

public class follower : MonoBehaviour
{
    public GameObject seek;
    public float Xsens = 1f;
    public float Ysens = 1f;
    private float pitch = 0;
    private float yaw = 0;
    void Start()
    {

    }

    void Update()
    {
        transform.position = seek.transform.position;
                
        pitch += Input.GetAxis("Mouse Y") * Ysens * -1;
        yaw += Input.GetAxis("Mouse X") * Xsens;
        transform.rotation = Quaternion.Euler(pitch,yaw,0);
        transform.rotation = Quaternion.Euler(pitch,yaw,0);
    }
}
