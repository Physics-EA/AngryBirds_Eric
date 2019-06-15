using UnityEngine;
using System.Collections;

public class animatorCtrl : MonoBehaviour
{
    public MainGameCtrl mainCtrl;
    public scoreCtrl theScore;
    public float destroyForce;  //20
    public float broke1Force;   //10
    public float broke2Force;   //15
    public int blood = 30;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.sqrMagnitude > destroyForce || blood <= 0)
        {
            GameObject go = Instantiate(mainCtrl.woodLScoreShow, transform.position, mainCtrl.woodLScoreShow.transform.rotation) as GameObject;
            theScore.score += 500;
            go.SetActive(true);
            Destroy(go, 1f);
            Destroy(gameObject);
        }

        if (collision.relativeVelocity.sqrMagnitude > broke1Force)
        {
            transform.GetComponent<Animator>().SetBool("broke1",true);
        }

        if (collision.relativeVelocity.sqrMagnitude > broke2Force)
        {
            transform.GetComponent<Animator>().SetBool("broke1", true);
            transform.GetComponent<Animator>().SetBool("broke2", true);
        }

        if (collision.relativeVelocity.sqrMagnitude > 5)
        {
            blood -= 20;
        }
    }
}
