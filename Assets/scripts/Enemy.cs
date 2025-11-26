using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Enemy : MonoBehaviour
{
    public GameObject EnemyPrefab;
    [Header("Health")]
    public int maxHealth = 100;
    private int currentHealth;

    private Vector3 spawnPos;
    private Quaternion spawnRot;

    private Collider col;
    private Renderer rend;

    void Start()
    {
        currentHealth = maxHealth;

        spawnPos = transform.position;
        spawnRot = transform.rotation;

        col = GetComponent<Collider>();
        rend = GetComponent<Renderer>();
    }

    public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                StartCoroutine(RespawnAfterDelay());
            }
        }
    
    private IEnumerator RespawnAfterDelay()
        {
            // “die”: hide and disable collisions
            col.enabled = false;
            if (rend != null) rend.enabled = false;

            // wait 2 seconds
            yield return new WaitForSeconds(2f);

            // “respawn”
            transform.SetPositionAndRotation(spawnPos, spawnRot);
            currentHealth = maxHealth;

            col.enabled = true;
            if (rend != null) rend.enabled = true;
        }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("gun")){
            TakeDamage(25);
            Destroy(other.gameObject);
        }
    }
}   
