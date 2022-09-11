using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed, timerToShoot, howMuchDown;
    public GameObject Bullet;
    public int health;
    public bool goingLeft;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (goingLeft == true)
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;
        }

        else
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

        }

        if (Mathf.Abs(transform.position.x) >= 2)
        {
            GoDownAndTurn();

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ow");
        if (collision.transform.tag == "Bullet") ;
        {
            Destroy(collision.gameObject);
            health--;
            if (health <= 0)
            {
                Die();
            }
        }
    }
    void GoDownAndTurn()
    {
        speed *= 1.3f;
        transform.position -= Vector3.up * howMuchDown;
        goingLeft = !goingLeft;

    }
    void Die()
    {
        Destroy(gameObject);
    }
}

