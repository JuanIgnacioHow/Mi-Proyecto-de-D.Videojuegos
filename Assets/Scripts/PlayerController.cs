using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerLife = 5;
    public string namePlayer = "Mr clean";
    public float speedPlayer;
    public void Damage ()
    {
        playerLife -= 1;
    }
    public void Healing ()
    {
        playerLife += 1;
    }
    public void Movement()
    {
        transform.position += miDireccion * speedPlayer* Time.deltaTime;
    }
   
    public Vector3 miEscala;
    public Vector3 miDireccion;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("en el frame inicial");
        Debug.Log(transform.position);
        transform.position = new Vector3 (0, 0.46f, -10);
        Debug.Log(transform.localScale);
        transform.localScale = miEscala;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("en el frame que sigue");
        Debug.Log(playerLife);
        transform.Rotate(0f, 5f, 0f, Space.Self);
        Debug.Log(transform.position);
        Movement();
        Damage();
        Healing();
    }
}
