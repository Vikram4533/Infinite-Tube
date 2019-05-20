using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{

    // Use this for initialization
    private Transform player;

    public float smmothspped = 0.125f;
    public Vector3 offset;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vik = new Vector3(0, 0, transform.position.z);
        if (player)
        {
            Vector3 desiredposition = player.position + offset;
            Vector3 smoothpos = Vector3.Lerp(vik, desiredposition, 0.125F);
            transform.position = smoothpos;
        }
    }

}
