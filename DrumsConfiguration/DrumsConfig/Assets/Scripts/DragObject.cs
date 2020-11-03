using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    Plane movePlane;
    float fixedDistance = 2f;
    float hitDist, t;
    Ray camRay;
    Vector3 startPos, point, corPoint;
    Rigidbody RBody;

    float speedRot = 30;

    void OnMouseDown()
    {
        startPos = transform.position; // save position in case draged to invalid place
        movePlane = new Plane(-Camera.main.transform.forward, transform.position); // find a parallel plane to the camera based on obj start pos;
        Debug.Log("ABAJO");
        
    }

    void OnMouseDrag()
    {
        RBody = GetComponent<Rigidbody>();
        //RBody.constraints = RigidbodyConstraints.None;
        RBody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
       

        camRay = Camera.main.ScreenPointToRay(Input.mousePosition); // shoot a ray at the obj from mouse screen point

        if (movePlane.Raycast(camRay, out hitDist))
        { // finde the collision on movePlane
            point = camRay.GetPoint(hitDist); // define the point on movePlane
            t = -(fixedDistance - camRay.origin.y) / (camRay.origin.y - point.y); // the x,y or z plane you want to be fixed to
            corPoint.x = camRay.origin.x + (point.x - camRay.origin.x)  ; // calculate the new point t futher along the ray
            //corPoint.y = camRay.origin.y + (point.y - camRay.origin.y) * t;
            corPoint.z = camRay.origin.z + (point.z - camRay.origin.z)  ;
            transform.position = corPoint;


        }

        if (Input.GetKey(KeyCode.A))
        {
            
            transform.Rotate(0.0f, speedRot * Time.deltaTime, 0.0f, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, -speedRot * Time.deltaTime, 0.0f , Space.Self);

        }


    }

    private void OnMouseExit()
    {
        RBody = GetComponent<Rigidbody>();
        //RBody.constraints = RigidbodyConstraints.FreezeAll;
    }



}