using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTapManager : MonoBehaviour
{
    bool isEnabled = false;

    public void onObjectTap()
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
