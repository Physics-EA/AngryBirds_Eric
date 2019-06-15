using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class birdMove : MonoBehaviour
{
    public MainGameCtrl mainGameCtrl;
    public GameSlingshotMove gsm;
    public GameObject slingshot;
    protected Rigidbody2D r2d;
    protected bool flag = true;
    public bool myturn = false;
    public int birdStep = 0;
    public float forceMode;
    public float gravityMode;
    protected bool IsMyturnOnSlingshot = true;
    public Mouse mouse;
    public Animator birdA;
    public List<AudioSource> audioSources;
    public PolygonCollider2D pc2d;
    public bool addScore = true;
    public bool deadandCountScore = true;
    public scoreCtrl score;
    public GameObject BirdScore;

    void Start()
    {
        r2d = transform.GetComponent<Rigidbody2D>();
        r2d.isKinematic = true;
        pc2d.enabled = false;
        //r2d.AddForce(new Vector2(1, 3), ForceMode2D.Impulse);
    }

    protected void myturnOnSlingshot()
    {
        pc2d.enabled = true;
        transform.position = slingshot.transform.position + new Vector3(0, 0.6f, 0);
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
                audioSources[1].Play();
                flag = false;
                r2d.isKinematic = false;
                myturn = false;
                birdStep = 1;
                r2d.gravityScale = gravityMode;
                r2d.AddForce((slingshot.transform.position + new Vector3(0, 0.45f, 0) - transform.position) * 100 * forceMode, ForceMode2D.Force);
                birdA.SetBool("fly", true);
            }
        }

        deadAndCountScore();
        AddScore();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        birdStep = 4;   //终点
        birdA.SetBool("collision", true);
    }

    public void AddScore()
    {
        if (birdStep==0 && mainGameCtrl.step == 5 && addScore)
        {
            GameObject go = Instantiate(BirdScore,transform.position + new Vector3(0,1,0), BirdScore.transform.rotation) as GameObject;
            Destroy(go, 1);
            score.score += 10000;
            addScore = false;
        }
    }


    public void deadAndCountScore()
    {
        if (birdStep == 4)
        {
            
            bool flag = false;
            for (int j = 0; j < mainGameCtrl.pigs.Count; j++)
            {
                if (mainGameCtrl.pigs[j] != null)
                {
                    flag = true;
                    break;
                }
            }
            

            if (flag == false && deadandCountScore)
            {
                mainGameCtrl.step = 4;
                deadandCountScore = false;
            }

            
        }
    }
}
