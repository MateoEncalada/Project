using System;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public GameObject DItem;
    public Transform transform;
    public event Action<GameObject> OnEnemyDestroyed;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die ()
    {
        OnEnemyDestroyed?.Invoke(gameObject);
        Destroy(gameObject);
        DropItem();
    }
      void DropItem()
     {
        Vector3 position = transform.position;
        GameObject item = Instantiate(DItem, position,Quaternion.identity);

     }
}
