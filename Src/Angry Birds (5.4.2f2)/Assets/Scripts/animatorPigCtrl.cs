using UnityEngine;
using System.Collections;

public class animatorPigCtrl : animatorCtrl
{
    public GameObject expl;
    // Use this for initialization
    void Start()
    {
        expl.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public new void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.sqrMagnitude > destroyForce || blood <= 0)
        {
            expl.SetActive(true);
            transform.GetComponent<Animator>().enabled = false;
            transform.GetComponent<PolygonCollider2D>().enabled = false;
            transform.GetComponent<SpriteRenderer>().enabled = false;
            GameObject go = Instantiate(mainCtrl.pigScoreShow,transform.position, mainCtrl.pigScoreShow.transform.rotation) as GameObject;
            theScore.score += 5000;
            go.SetActive(true);
            Destroy(go, 1f);
            Destroy(gameObject,1f);
        }

        if (collision.relativeVelocity.sqrMagnitude > broke1Force)
        {
            transform.GetComponent<Animator>().SetBool("broke1",true);
        }

        if (collision.relativeVelocity.sqrMagnitude > 5)
        {
            blood -= 20;
        }
    }
}
