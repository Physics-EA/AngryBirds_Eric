using UnityEngine;
using System.Collections;

public class BGbirdMove : MonoBehaviour
{

    public GameObject finger;
    public GameObject bird;
    public BGScript BG;
    public Rigidbody2D r2d;
    bool addForce = true;
    public Animator a;
    public GameObject explosion;
    public GameObject lineSpot1;
    public GameObject lineSpot2;
    public GameObject line;
    int lineSpot2Num = 0;
    // Use this for initialization
    void Start()
    {
        r2d.gravityScale = 0;
        explosion.SetActive(false);
        lineSpot1.SetActive(false);
        lineSpot2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (BG.step == 1)
        {
            Reset();
        }
        if (BG.step == 2)
        {
            if (finger.transform.position != null)
            {
                bird.transform.position = finger.transform.position;
            }
        }


        if (BG.step == 3 && addForce)
        {
            a.SetBool("fly",true);
            r2d.gravityScale = 1;
            r2d.AddForce(new Vector2(6, 3), ForceMode2D.Impulse);
            addForce = false;
            
        }

        if (BG.step == 3)
        {
            if (lineSpot2Num % 3 == 0)
            {
                GameObject go = Instantiate(lineSpot2, r2d.transform.position, lineSpot1.transform.rotation) as GameObject;
                go.SetActive(true);
                go.transform.parent = line.transform;
                lineSpot2Num = 0;
            }
            else
            {
                GameObject go = Instantiate(lineSpot1, r2d.transform.position, lineSpot1.transform.rotation) as GameObject;
                go.SetActive(true);
                go.transform.parent = line.transform;
            }
            
            lineSpot2Num++;
        }
    }

    public void Reset()
    {
        bird.transform.position = new Vector3(-1.679f, 0.166f, 0);
        bird.transform.rotation = new Quaternion(0, 0, 0, 0);
        r2d.gravityScale = 0;
        addForce = true;
    }


    void destroyE()
    {
        explosion.SetActive(false);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        BG.step = 4;

        if (collision.transform.tag == "pig")
        {
            explosion.SetActive(true);
            Invoke("destroyE", 0.1f);
            collision.gameObject.SetActive(false);
        }

        if (collision.transform.tag == "BG")
        {
            a.SetTrigger("down");
        }

    }
}
