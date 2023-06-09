using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 3.5f;

    [SerializeField]
    private float minBound_X = -71f, maxBound_X = 71f, minBound_Y = -3.3f, maxBound_Y = 0f;
    
    private Vector3 tempPos;

    private float xAxis, yAxis;

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement() {
        // Return -1, 0, 1 right away
        xAxis = Input.GetAxisRaw(TagManager.HORIZONTAL_AXIS);
        yAxis = Input.GetAxisRaw(TagManager.VERTICAL_AXIS);

        tempPos = transform.position;
        tempPos.x += xAxis * moveSpeed * Time.deltaTime;
        tempPos.y += yAxis * moveSpeed * Time.deltaTime;

        if (tempPos.x < minBound_X)
        {
            tempPos.x = minBound_X;
        }

        if (tempPos.x > maxBound_X)
        {
            tempPos.x = maxBound_X;
        }

        if (tempPos.y < minBound_Y)
        {
            tempPos.y = minBound_Y;
        }

        if (tempPos.y > maxBound_Y)
        {
            tempPos.y = maxBound_Y;
        }
        
        transform.position = tempPos;
    }
}
