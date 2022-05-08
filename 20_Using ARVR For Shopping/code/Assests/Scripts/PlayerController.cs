using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle;
    public CharacterController characterController;
    public float walkSpeed;


    // Start is called before the first frame update
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(vrCamera.eulerAngles.x);
        if (vrCamera.eulerAngles.x > toggleAngle && vrCamera.eulerAngles.x < 90f)
        {
            moveForward();
        }
    }

    private void moveForward()
    {
        Vector3 cameraForward = vrCamera.TransformDirection(-vrCamera.forward);
        characterController.SimpleMove(cameraForward * walkSpeed);
    }
}
