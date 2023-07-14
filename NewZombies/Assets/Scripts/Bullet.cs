using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 5f;
    private Rigidbody bulletRigidBody;


    void Awake()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(Vector3 directionToPoint)
    {
        bulletRigidBody.AddForce(directionToPoint * bulletSpeed, ForceMode.Impulse);
        Destroy(gameObject, 5f);
    }
}
