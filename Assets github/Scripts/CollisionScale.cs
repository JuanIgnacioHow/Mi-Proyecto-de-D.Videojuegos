using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScale : MonoBehaviour
{
    public GameObject theBean;
    public Vector3 sizePlayer;
    public bool yaPase = false;
    public bool puedoPasar = true;
    private float timer = 0;
    private float timerTeleport = 0;
    public GameObject[] TeleportPoints;
    public int indice = 0;
    public int vista = 0;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 6 && puedoPasar ==true)
        {
            Debug.Log("Pasa por el portal");
            puedoPasar = false;

            if (yaPase == false)
            {
                transform.localScale = sizePlayer;
                yaPase = true;
            }
         else 
            {
                transform.localScale = new Vector3(1, 1, 1);
                yaPase = false;
            }
            
        }
        if (other.gameObject.layer == 7)
        {
            timerTeleport = 0;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            timerTeleport += Time.deltaTime;

            if (timerTeleport >= 2)
            {
                Debug.Log("teleport");
                timerTeleport = 0;
                indice = Random.Range(0, TeleportPoints.Length);
                other.gameObject.transform.position = TeleportPoints[indice].transform.position;
                other.gameObject.transform.rotation = TeleportPoints[indice].transform.rotation;

                //if(indice == TeleportPoints.Length-1)
                //{
                //    indice = 0;
                //}
                //else
                //{
                //    indice += 1;
                //}
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puedoPasar == false)
        {
            timer += Time.deltaTime;
            if (timer>= 2)
            {
                puedoPasar = true;
                timer = 0;
            }
        }
    }
}
