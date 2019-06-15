using UnityEngine;
using System.Collections;

public class GameSlingshotMove : MonoBehaviour {

    public Mouse mouse;
    public LineRenderer liner;
    public GameObject Slingshot;
    public Vector3 vL;
    public Vector3 v;
    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (mouse.pull)
        {
            vL = new Vector3(mouse.v3.x, mouse.v3.y, 0);
            v = vL - Slingshot.transform.position;
            if (v.magnitude < 0.5f)
            {
                liner.SetPosition(1, v);
            }
            else
            {
                liner.SetPosition(1, v.normalized * 0.5f);
                vL = v.normalized * 0.5f + Slingshot.transform.position;
            }

        }
        else
        {
            liner.SetPosition(1, Vector3.zero);
        }


    }
}
