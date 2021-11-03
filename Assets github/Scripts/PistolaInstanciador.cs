using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PistolaInstanciador : MonoBehaviour
{
    public Vector3 sizeBullet;
    public GameObject Bullet;
    public float startDelay = 1.5f;
    public float spawnInterval = 2;
    
    private void BulletSpawn()
    {
        Instantiate(Bullet, transform.position, Bullet.transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BulletSpawn", startDelay, spawnInterval);
    }

    // Update is called once per frame
    private void SizeChanger()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet.transform.localScale += sizeBullet;
        }
    }
    void Update()
    {
        SizeChanger();
    }
    
}