using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolaInstanciador : MonoBehaviour
{
    public GameObject Bullet;

    private void BulletSpawn()
    {
        Instantiate(Bullet, transform.position, Bullet.transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        BulletSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
