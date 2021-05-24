using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGoOfficeScript : MonoBehaviour
{
    //initialization

    int startPoint=0;
    int endPoint=10;
    int distance = 0;
    // Start is called before the first frame update
    void Start()
    {
    
        Debug.Log("Hey Welcome to My game GoOffice");
        Debug.Log("To Play this game Please use Keyboard");
        Debug.Log("Press UpArrow to move Forward");
        Debug.Log("Use DownArrow to move backward");
        distance = endPoint - startPoint;
        print("Your Starting point is " + startPoint + "Your End point is " + endPoint);
        print("Distance to Reach Office is:" + distance);

        if (distance > startPoint)
        {
            print("Please Move Forward");
        }
        else if (distance < startPoint) {
            print("Please Move Backward");
        }
        else if(distance == startPoint)
        {
            print("Hey you already reached the destination");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            startPoint = startPoint + 1;
            distance = endPoint - startPoint;
            print("Distance to Reach Office is:" + distance);
            if (distance > 0)
            {
                print("Please Move Forward");
            }
            else if (distance < 0)
            {
                print("Please Move Backward");
            }
            else if (distance == 0)
            {
                print("Hey You reached the office");
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            startPoint = startPoint - 1;
            print("Hello You Pressed Down arrow");
            distance = endPoint - startPoint;
            print("Distance to Reach Office is:" + distance);
            if (distance < 0)
            {
                print("Please Move Forward");
            }
            else if (distance > 0)
            {
                print("Please Move Backward");
            }
            else if (distance == 0)
            {
                print("Hey You reached the office");
            }
        }
    }
}
