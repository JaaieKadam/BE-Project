using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{   
    public void red() {
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void green() {
        GetComponent<Renderer>().material.color = Color.green;
    }
    public void blue() {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
