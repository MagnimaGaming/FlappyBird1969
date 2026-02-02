using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMov : MonoBehaviour
{
    //public Transform top;
    //public Transform bottom;
    public float speed = 5f;
    public float gap = 3f;

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;

        // Set gap between top and bottom pipes
       // top.position += Vector3.up * gap / 2;
       // bottom.position += Vector3.down * gap / 2;
    }

    private void Update()
    {
        // Move pipe to the left continuously
        transform.position += speed * Time.deltaTime * Vector3.left;

        // Destroy pipe when it goes off screen
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }


}
