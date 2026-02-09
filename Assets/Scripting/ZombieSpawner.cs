using UnityEditor.Tilemaps;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombie;
    public float spawnRate = 2f;
    private float spawnTimer;
    private int maxZombies = 5;
    private int currentZombies = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentZombies>= maxZombies)
        {
            return;
        }
        spawnTimer += Time.deltaTime;
        if(spawnTimer >= spawnRate)
        {
            SpawnZombie();
            spawnTimer = 0f;
        }
    }
    void SpawnZombie()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-5f, 5f), 8f);
        Instantiate(zombie, transform.position, Quaternion.identity);
        currentZombies++;
    }
}
