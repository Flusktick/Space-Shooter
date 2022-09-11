using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float cooldowmtimer = .05f;
    float timerlength;
    public GameObject Bullet;
    public Transform gun;
    // Start is called before the first frame update
    void Start()
    {
        timerlength = cooldowmtimer;
        cooldowmtimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && cooldowmtimer <= 0);
        {
            GameObject.Instantiate(Bullet, gun.position, Quaternion.identity);
        cooldowmtimer = timerlength;
             }
        if (cooldowmtimer >= 0)
        {
            cooldowmtimer -= Time.deltaTime;
        }

 
    }
}
