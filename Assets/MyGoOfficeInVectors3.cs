using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGoOfficeInVectors3 : MonoBehaviour
{
    public Vector3 startPoint;
    public Vector3 endPoint;
    public Vector3 distance;
    public void PrintDistance() // No Parameter  
    {
        distance = endPoint - startPoint;
        print("The Total Distance to reach Office is " + distance.magnitude);
        if (startPoint == endPoint)
        {
            print("Your Reached Office");
        }
    }
        // Start is called before the first frame update
    void Start()
    {
        print("Welcome To My Game GoOffice");
        print("Please W to move to top, \n S to move down,\n A to move left,\n D to move right\n Q to move forward \n E to move backward");
        distance = endPoint - startPoint;
        print("The Total Distance to reach Office is " + distance.magnitude);

        if (startPoint.magnitude > endPoint.magnitude)
        {
            print("Move Forward");
        }
        else if (startPoint.magnitude < endPoint.magnitude)
        {
            print("Move Backward");
        }
        else
        {
            print("Reached the destination");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            startPoint += new Vector3(0, 1,0);
            PrintDistance();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            startPoint += new Vector3(0, -1,0);
            PrintDistance();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            startPoint += new Vector3(-1, 0,0);
            PrintDistance();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            startPoint += new Vector3(1, 0,0);
            PrintDistance();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            startPoint += new Vector3(0, 0, 1);
            PrintDistance();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            startPoint += new Vector3(0, 0, -1);
            PrintDistance();
        }
    }
}
