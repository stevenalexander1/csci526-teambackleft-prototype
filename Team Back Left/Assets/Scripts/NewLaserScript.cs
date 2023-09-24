using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLaserScript : MonoBehaviour
{
    private LineRenderer lr;

    private GameManagerer gameManager;

    [SerializeField]
    private Transform startPoint;
    [SerializeField]
    private float moveSpeed = 2.0f; // Adjust this to control the speed of movement

    private float maxY = 3.0f; // Adjust this to set the maximum height
    private float minY = 1.0f; // Adjust this to set the minimum height
    private bool movingUp = true;
    private bool gameOver = false;


 void Start()
    {
        lr = GetComponent<LineRenderer>();
        gameManager = FindObjectOfType<GameManagerer>(); // Find the GameManager in the scene
    }

    void Update()
    {
        if (!gameOver)
        {    
        // Move the startPoint up and down
        Vector3 newPosition = startPoint.position;
        if (movingUp)
        {
            newPosition.y += moveSpeed * Time.deltaTime;
            if (newPosition.y >= maxY)
            {
                newPosition.y = maxY;
                movingUp = false;
            }
        }
        else
        {
            newPosition.y -= moveSpeed * Time.deltaTime;
            if (newPosition.y <= minY)
            {
                newPosition.y = minY;
                movingUp = true;
            }
        }
        startPoint.position = newPosition;

        // Update the laser position
        lr.SetPosition(0, startPoint.position);
        RaycastHit hit;
            if (Physics.Raycast(transform.position, -Vector3.back, out hit))
            {
                if (hit.collider)
                {
                    lr.SetPosition(1, hit.point);

                    if (hit.transform.CompareTag("Player"))
                    {
                        gameOver = true;
                        gameManager.GameOver(); // Call the GameManager's GameOver method
                    }
                }
            }
            else
            {
                lr.SetPosition(1, -Vector3.back * 5000);
            }
        }
    }
}

