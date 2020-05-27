using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject circlePrefab;
    public GameObject flashPrefab;
    public float counterSet = 3f;
    public float counter = 3f;
    public float circleCap = 5f;

    // Update is called once per frame
    void Update()
    {
        RunCounter();

        if(counter == 0f && circleCap > 0)
        {
            Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            Instantiate(circlePrefab, position, Quaternion.identity);
            ResetCounter();
            circleCap++;
        }
     
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Instantiate(flashPrefab, firePoint.position, firePoint.rotation);
    }

    void RunCounter()
    {
        counter -= 1f;
    }

    void ResetCounter()
    {
        counter = counterSet;
    }
}