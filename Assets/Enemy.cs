using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    float currentHealth = 10;
    float maxHealth = 100;

    public EnemyLootDrop lootSpawner;
    //static ItemDataBaseList inventoryItemList;
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
 public void Awake()
    {
        currentHealth = maxHealth;
        //inventoryItemList = (ItemDataBaseList)Resources.Load("ItemDatabase");
    }
 public void Update()
    {
        if (currentHealth <=0)
        {
            Destroy(gameObject);
            lootSpawner.DropLoot(new Vector2(this.transform.position.x, this.transform.position.y), 1);
        }
    }
 public void Damage(int damage)
    {
        currentHealth -= damage;
    }
}
