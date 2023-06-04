using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TowardPlayer : MonoBehaviour
{

    private GameObject player;
    private float speed = 0.1f;

    private void Start()
    {
        player = GameObject.Find("XR Origin");
    }
    void Update()
    {
        Vector3 heading = player.transform.position - transform.position;

        if(heading.sqrMagnitude > 1)
        {
            transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * speed);
        }
        transform.LookAt(player.transform);

    }
}
