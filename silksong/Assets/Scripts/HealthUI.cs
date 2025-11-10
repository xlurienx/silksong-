
using System;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    //tools for UI
    public Health playerHealth; 
    public GameObject heartPrefab;
    private List<GameObject> spawnedHearts = new List<GameObject>();
    private void Start()
    {
        CreateHearts();
        playerHealth.OnDamageTaken += UpdateHearts;
    }
    private void OnDestroy()
    {
        playerHealth.OnDamageTaken -= UpdateHearts;
    }
    private void UpdateHearts() //on damage lose hearts
    {
        for (int i = 0;i < spawnedHearts.Count;i++)
        {
            Destroy(spawnedHearts[i]);

        }
        CreateHearts();

    }
    private void CreateHearts()
    {
        for (int i = 0; i < playerHealth.CurrentHealth; i++)
        {
            GameObject spawnedHeart = Instantiate(heartPrefab, transform);
            spawnedHearts.Add(spawnedHeart);
        }
    }
}
