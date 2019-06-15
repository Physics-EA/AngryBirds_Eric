using UnityEngine;
using System.Collections;

public class YbirdMove : birdMove
{

    void Start()
    {
        r2d = transform.GetComponent<Rigidbody2D>();
        r2d.isKinematic = true;
        pc2d.enabled = false;
        //r2d.AddForce(new Vector2(1, 3), ForceMode2D.Impulse);
    }


    // Update is called once per frame
    void Update()
    {
        if (myturn && mouse.pull == false)
        {
            if (IsMyturnOnSlingshot)
            {
                Invoke("myturnOnSlingshot", 1f);
                IsMyturnOnSlingshot = false;
            }
        }

        if (myturn && mouse.pull)
        {
            if (flag)
            {
                transform.position = gsm.vL;
            }

            if (Input.GetMouseButtonUp(0))
            {
                audioSources[0].Play();
                birdStep = 1;
                flag = false;
                r2d.isKinematic = false;
                r2d.gravityScale = 1;
                r2d.AddForce((slingshot.transform.position + new Vector3(0, 0.45f, 0) - transform.position) * 100 * forceMode, ForceMode2D.Force);
                birdA.SetBool("fly", true);
            }
        }

        if (Input.GetMouseButtonDown(0) && birdStep == 1)
        {
            birdStep = 2;
            myturn = false;
            r2d.AddForce(r2d.velocity * 10 * forceMode, ForceMode2D.Force);
        }

        deadAndCountScore();
        AddScore();

    }

    public new void OnCollisionEnter2D(Collision2D collision)
    {
        birdStep = 4;   //终点
        birdA.SetBool("collision", true);
        myturn = false; 
    }
}
