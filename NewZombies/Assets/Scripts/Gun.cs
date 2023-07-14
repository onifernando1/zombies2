using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private Bullet bullet;
    private Vector3 targetPoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (inputManager.PlayerShot())
        {

            //Get centre of screen
            Vector2 CenterOfScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);

            // Find hit position using raycast

            Ray ray = Camera.main.ScreenPointToRay(CenterOfScreen);

            if(Physics.Raycast(ray, out RaycastHit raycastHit, 999f))
            {
                targetPoint = raycastHit.point;
            } 
            else
            {
                targetPoint = ray.GetPoint(75);
            }

            //Find direction to point


            Vector3 directionToPoint = targetPoint - bulletSpawnPoint.position;

            // create bullet 
            Bullet currentBullet = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);

            // Rotate bullet 
            currentBullet.transform.forward = directionToPoint.normalized;

            //Fire bullet 

            currentBullet.Shoot(directionToPoint);






        }
        
    }

}
