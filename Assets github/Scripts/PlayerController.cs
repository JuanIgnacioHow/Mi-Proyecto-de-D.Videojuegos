using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerLife = 5;
    public string namePlayer = "Mr clean";
    public float speedPlayer;
    public Vector3 playerDirection;
    private void moveLeft()
    {
        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3 (-90, 0, 0)* speedPlayer * Time.deltaTime;
    }
    private void moveRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(90, 0, 0) * speedPlayer * Time.deltaTime;
        }
    }

    private void moveFoward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 90) * speedPlayer * Time.deltaTime;
        }
    }

    private void moveBack()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -90) * speedPlayer * Time.deltaTime;
        }
    }

    public void Damage ()
    {
        playerLife -= 1;
    }
    public void Healing ()
    {
        playerLife += 1;
    }
    
   
    
    
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        moveLeft();
        moveRight();
        moveFoward();
        moveBack();
    }
}
