using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float flyUp;
    [SerializeField] private LayerMask layerMask;

    Rigidbody2D rb2d;
    PolygonCollider2D pg2d;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hit Enemy!");
            GameManager._instance.ShowGameOver();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        pg2d = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb2d.AddForce(new Vector2(0, flyUp), ForceMode2D.Impulse);
        }
    }
}
