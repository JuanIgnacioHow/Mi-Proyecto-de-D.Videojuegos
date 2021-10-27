using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject[] cameras;
    private void followCamera()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            cameras[0].SetActive(true);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
        }
    }
    private void cinematicCamera()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(true);
            cameras[2].SetActive(false);
        }
    }

    private void detailCamera()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        followCamera();
        cinematicCamera();
        detailCamera();
    }
}
