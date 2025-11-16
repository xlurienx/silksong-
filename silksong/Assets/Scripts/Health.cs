using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int CurrentHealth; // Player's current health
    public int MaxHealth; // Player's max health
    public event Action OnDeath = delegate { }; // Event that happens when player dies
    public bool IsDead; // Whether the player is dead
    public event Action OnDamageTaken = delegate { }; // Event that happens when player takes damage

    public void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (IsDead) // Don't do anything if already dead 
        {
            return;
        }
        CurrentHealth -= damage; // Subtract damage from curr health
        OnDamageTaken.Invoke();

        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            IsDead = true;
            OnDeath.Invoke(); // Tell any listeners that player died
        }
    }

}