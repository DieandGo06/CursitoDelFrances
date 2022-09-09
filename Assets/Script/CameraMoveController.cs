using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveController : MonoBehaviour
{
    [SerializeField] private float lookSensivity;
    [SerializeField] private float smothing;
    
    private GameObject player;
    private Vector2 smoothedVelocity;
    private Vector2 currentLookingPos;

    private void Start()
    {
        player = transform.parent.gameObject;
    }

    private void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        Vector2 inputValues = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        inputValues = Vector2.Scale(inputValues, new Vector2(lookSensivity * smothing, lookSensivity * smothing));
        smoothedVelocity.x = Mathf.Lerp(smoothedVelocity.x, inputValues.x, 1 / smothing);
        smoothedVelocity.y = Mathf.Lerp(smoothedVelocity.y, inputValues.y, 1 / smothing);
        currentLookingPos += smoothedVelocity;

        //transform.localRotation = Quaternion.AngleAxis(-currentLookingPos.y, Vector3.right); 
        //player.transform.localRotation = Quaternion.AngleAxis(currentLookingPos.x, player.transform.up);

        transform.localRotation = Quaternion.AngleAxis(-currentLookingPos.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(currentLookingPos.x, player.transform.up);
    }
}
