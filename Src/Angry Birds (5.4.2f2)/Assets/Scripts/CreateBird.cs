using UnityEngine;
using System.Collections;

public class CreateBird : MonoBehaviour {

    public GameObject Rb;
    public GameObject Bb;
    GameObject goI;
    float createBirdTime = 0;


	// Use this for initialization
	void Start ()
    {
        Rb.SetActive(false);
        Bb.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        createBirdTime += Time.deltaTime;
        if (createBirdTime > 2f)
        {
            createBirdTime = 0;
            createBird();
        }
	}


    void createBird()
    {
        int b = Random.Range(0, 2);
        float x = Random.Range(-10, 4);
        float s = Random.Range(1, 3);
        if (b == 0)
        {
            goI = Rb;
        }
        else
        {
            goI = Bb;
        }
        GameObject go = Instantiate(goI,new Vector2(x,-5.5f), goI.transform.rotation) as GameObject;
        go.transform.localScale = new Vector3(s,s,s);
        go.SetActive(true);
    }
}
