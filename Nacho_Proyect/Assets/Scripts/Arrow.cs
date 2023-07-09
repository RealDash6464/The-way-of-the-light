using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    public float resetcont;
    public float speed;
    public bool isLeft;
    public Rigidbody2D rb;
    private float cont;
    // Start is called before the first frame update
    void Start()
    {
        cont = 0;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cont >= resetcont)
        {
            Destroy(gameObject);
            cont = 0;
        }
        else
        {
            if (isLeft)
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
                transform.localScale = new Vector3(-0.7f, 0.7f, 1f);
            }
            else
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
                transform.localScale = new Vector3(0.7f, 0.7f, 1f);
            }
            cont += Time.deltaTime;
        }
    }
}
