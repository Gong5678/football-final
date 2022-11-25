using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool stickToPlayer;
    [SerializeField] private Transform tranfromPlayer;
    [SerializeField] private Transform playerBallPosition;
    float speed;
    Vector3 previousLocation;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (!stickToPlayer)
        {
            float distanceToPlayer = Vector3.Distance(tranfromPlayer.position, transform.position);
            if (distanceToPlayer < 0.5)
            {
                stickToPlayer = true;
            }
        }
        else
        {
            Vector2 currentLocation = new Vector2(transform.position.x, transform.position.z);
            speed = Vector2.Distance(currentLocation, previousLocation) / Time.deltaTime;
            transform.position = playerBallPosition.position;
            transform.Rotate(new Vector3(tranfromPlayer.right.x, 0, tranfromPlayer.right.z), speed, Space.World);
            previousLocation = currentLocation;
        }
    }
}
