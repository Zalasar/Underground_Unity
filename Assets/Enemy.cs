﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    [System.Serializable]
    public class EnemyStats
    {
        public float maxHealth = 100;

        private float _curhealth=10;
        public float currentHealth
        {
            get { return _curhealth; }
            set { _curhealth = Mathf.Clamp(value, 0, maxHealth);  }

        }

        public void Init()
        {
            currentHealth = maxHealth;
            Debug.Log(currentHealth);
        }
    
    }

    public EnemyLootDrop lootSpawner;
    
    float damage = 10;
  

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.SendMessageUpwards("Damage", damage);
            
        }
        Debug.Log("Hit");
        
    }
    public EnemyStats stats = new EnemyStats();

    [Header("Optional: ")]
    [SerializeField]
    private StatusIndicator statusIndicator;

    void Start()
    {
        stats.Init();   
        
        if (statusIndicator != null)
        {
            statusIndicator.SetHealth(stats.currentHealth, stats.maxHealth);
        }
    }
    public void Update()
    {
        if (stats.currentHealth <= 0)
        {
            Destroy(gameObject);
            lootSpawner.DropLoot(new Vector2(this.transform.position.x, this.transform.position.y), 1);
        }
        if (statusIndicator != null)
        {
            statusIndicator.SetHealth(stats.currentHealth, stats.maxHealth);
        }
    }
    public void Damage(int damage)
    {
            stats.currentHealth -= damage;
    }
}
