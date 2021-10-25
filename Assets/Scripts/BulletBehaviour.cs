using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float sizeBullet = 1;
    public float playerLife;
    public float speedObject;
    public Vector3 directionObject;
    public void Damage()
    {
        playerLife -= 3;
    }
    public void BulletSpeed()
    {
        transform.position += directionObject*speedObject * Time.deltaTime;
    }
    public float launchingTime;
    private float lifeTime;
    private void Reset()
    {
        lifeTime = launchingTime;
    }

    private void TimeOnAir()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting frame");
        Damage();
        Reset();
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletSpeed();
        TimeOnAir();
    }
    private void SizeChanger()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}

