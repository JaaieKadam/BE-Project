using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomUIRotator : MonoBehaviour
{

    Camera mainCam;
    public GameObject bottomUI;


    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        bottomUI.transform.rotation = Quaternion.Euler(mainCam.transform.rotation.eulerAngles);
    }
}
