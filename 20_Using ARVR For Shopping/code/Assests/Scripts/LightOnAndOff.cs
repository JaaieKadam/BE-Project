using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnAndOff : MonoBehaviour
{

    public bool isEnabled = false;

    public void lightOnAndOff()
    {
        if (!isEnabled)
        {
            gameObject.SetActive(true);
            isEnabled = true;
        }
        else
        {
            gameObject.SetActive(false);
            isEnabled = false;
        }
    }
}
