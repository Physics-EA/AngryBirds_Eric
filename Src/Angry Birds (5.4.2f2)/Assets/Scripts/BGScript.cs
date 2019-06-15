using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BGScript : MonoBehaviour {

    public GameObject finger;
    public int step = 1;
    public bool start = true;
	// Use this for initialization
	void Start ()
    {
        finger.SetActive(false);
        Invoke("fingerOut", 1f);
        start = false;
    }
	
    void fingerOut()    //step1
    {
        finger.transform.position = new Vector3(-1.58f, 0, -0.18f);
        finger.SetActive(true);
        finger.GetComponent<SpriteRenderer>().enabled = true;
        step = 2;
    }



    void fingerLose()  //step2
    {
        finger.GetComponent<SpriteRenderer>().enabled = false;
    }


    // Update is called once per frame
    void Update ()
    {
        if (step == 1 && start)
        {
            finger.SetActive(false);
            Invoke("fingerOut", 1f);
            start = false;
        }

        if (step == 2 && finger.transform.position.x < -2.25f)
        {
            step = 3;
            fingerLose();
        }
	}
}
