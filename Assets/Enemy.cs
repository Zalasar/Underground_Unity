using UnityEngine;
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
    //static ItemDataBaseList inventoryItemList;
    float damage = 10;
    //	[System.Serializable]
    //   public class EnemyStats
    //   {
    //       public int Health = 100;
    //   }
    //   public EnemyStats stats = new EnemyStats();

    //   public void DamageEnemy (int Damage)
    //   {
    //       stats.Health -= Damage;
    //       if(stats.Health <= 0)
    //       {
    //           GameMaster.KillEnemy(this);
    //       }
    //   }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.SendMessageUpwards("Damage", damage);
            //(Damage()
        }
        Debug.Log("Hit");
        //Destroy(gameObject);
        //Destroy(other.gameObject);
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
