using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
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

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting frame");
        Damage();
    }

    // Update is called once per frame
    void Update()
    {
        BulletSpeed();
    }
}
