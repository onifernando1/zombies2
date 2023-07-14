using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    private float health = 100f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsDead())
        {
            Death();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Bullet bullet))
        {
            Destroy(bullet);
            health -= 30;
            Debug.Log("Hit");
        }
    }

    private bool IsDead()
    {
        if (health <= 0)
        {
            return true;
        }
        return false;
    }

    private void Death()
    {
    }
}
