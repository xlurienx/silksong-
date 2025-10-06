using UnityEngine;

public class spawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject objectToSpawn;   // The prefab to spawn
    public float spawnInterval = 15f;  // time between spawns (seconds)

    [Header("Spawn Area (World Coordinates)")]
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -3f;
    public float maxY = 3f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    void SpawnObject()
    {
        // random position within bounds
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector2 spawnPosition = new Vector2(randomX, randomY);

        // instantiate the object
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

        Debug.Log("Spawned at: " + Time.time);
    }
}
