//BackgroundController.cs 
//(Controls the movement of a infinitely scrolling background using 2 objects)

//Blair White 100328532

//  Last Modified 10/21/2020:
// -Changed vertical boundary and speed to horizontal
// -Modified movement to move on the x axis not the y
// -Modified boundary for backgrounds to accomodate landscape mode
// -Rotated prefabs to reflect changes.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
