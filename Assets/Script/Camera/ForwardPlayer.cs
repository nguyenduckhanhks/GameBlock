using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardPlayer : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 1, -5);

    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
