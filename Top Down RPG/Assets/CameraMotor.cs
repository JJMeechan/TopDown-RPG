using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;

    public float boundX = 0.15f;
    public float boundY = 0.10f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        //checks if we are inside the bounds on the x axis
        float deltaX = lookAt.position.x - transform.position.x;
        if(deltaX > boundX || deltaX < -boundX)
        {
            //if the camera is left of the player
            if(transform.position.x < lookAt.position.x)
            {
                //updates the x value of the delta vector, to be used for camera movement
                delta.x = deltaX - boundX;
            }
            //if the camera is right of the player
            else
            {
                delta.x = deltaX + boundX;
            }
        }

        //checks if we are inside the bounds on the y axis
        float deltaY = lookAt.position.y - transform.position.y;
        if (deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < lookAt.position.y)
            {
                //updates the y value of the delta vector, to be used for camera movement
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }
        //updates the position of the camera using the delta vector values calculated in the if statements
        transform.position += new Vector3(delta.x, delta.y, 0);
    }

}
