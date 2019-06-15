using UnityEngine;
using System.Collections;

public class TeachfingerMove : MonoBehaviour {

    public GameObject finger;
    public BGScript BG;
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {


        if (BG.step == 2)
        {
            finger.transform.position = Vector3.Lerp(finger.transform.position, new Vector3(-2.3f, -0.23f, 0), 0.1f);
        }

        if (BG.step == 3)
        {
            finger.transform.position = Vector3.Lerp(finger.transform.position, new Vector3(-1.66f, 0.15f, -0.18f), 0.1f);
        }
        

    }
}
