using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGoOfficeScriptInVectors : MonoBehaviour
{
    public Vector2 startPoint;
    public Vector2 endPoint;
    public Vector2 distance;
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
        print("Please up Arrow to move to top, \n DownArrow to move down,\n LeftArrow to move left,\n Right Arrow to move right");
        distance = endPoint - startPoint;
        print("The Total Distance to reach Office is " + distance.magnitude);

        if(startPoint.magnitude > endPoint.magnitude)
        {
            print("Move Forward");
        }
        else if(startPoint.magnitude < endPoint.magnitude)
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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            startPoint = startPoint + new Vector2(0, 1);
            PrintDistance();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            startPoint = startPoint + new Vector2(0, -1);
            PrintDistance();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            startPoint = startPoint + new Vector2(-1, 0);
            PrintDistance();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            startPoint = startPoint + new Vector2(1, 0);
            PrintDistance();
        }
    }
}
