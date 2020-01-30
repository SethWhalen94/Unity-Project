using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_behavior : MonoBehaviour
{
    // Camera offset from player
    [SerializeField] private float yOffset = 6f;

    // Player Object Transform
    private GameObject player;
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");     //Finds player object
        playerTransform = player.transform;
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y + yOffset, -10);
    }

    // Update is called once per frame
    void Update()
    {
        playerTransform = player.transform;
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y + yOffset, -10);
    }
}
