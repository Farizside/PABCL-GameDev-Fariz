using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = -4f;

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x <= -100)
        {
            Destroy(gameObject);
        }
    }
}
