using UnityEngine;
using System.Collections;

public class slingshotLineMove : MonoBehaviour {

    public LineRenderer liner;
    public GameObject finger;
    public GameObject Slingshot;
    public BGScript BG;
    Vector3 v;
    public Vector3 end;
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (BG.step == 2 || BG.step == 3)
        {
            if (finger.transform.position != null)
            {
                v = finger.transform.position - Slingshot.transform.position;
                liner.SetPosition(1, v); //finger.transform.position- Slingshot.transform.position
            }
        }
            
    }
}
