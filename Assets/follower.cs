using UnityEngine;

public class follower : MonoBehaviour
{
    public GameObject seek;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = seek.transform.position;
    }
}
