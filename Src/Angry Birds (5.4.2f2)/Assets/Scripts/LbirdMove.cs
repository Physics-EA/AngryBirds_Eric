using UnityEngine;
using System.Collections;

public class LbirdMove : birdMove
{

    public GameObject bird1;
    public GameObject bird2;

    void Start()
    {
        r2d = transform.GetComponent<Rigidbody2D>();
        r2d.isKinematic = true;
        pc2d.enabled = false;
        //r2d.AddForce(new Vector2(1, 3), ForceMode2D.Impulse);
        bird1.SetActive(false);
        bird2.SetActive(false);
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
                birdStep = 1;
                flag = false;
                r2d.isKinematic = false;
                r2d.gravityScale = 1;
                r2d.AddForce((slingshot.transform.position + new Vector3(0, 0.45f, 0) - transform.position) * 100 * forceMode, ForceMode2D.Force);
            }
        }

        if (Input.GetMouseButtonDown(0) && birdStep == 1)
        {
            audioSources[0].Play();
            birdStep = 2;
            myturn = false;
            bird1.SetActive(true);
            bird1.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity;


            bird2.SetActive(true);
            bird2.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity;
        }
        deadAndCountScore();
        AddScore();
    }

    public new void OnCollisionEnter2D(Collision2D collision)
    {
        myturn = false;
        birdStep = 4;//终点
    }
}
