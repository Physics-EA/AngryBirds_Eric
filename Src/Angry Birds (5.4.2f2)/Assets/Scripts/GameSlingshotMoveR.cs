using UnityEngine;
using System.Collections;

public class GameSlingshotMoveR : MonoBehaviour {

    public LineRenderer liner;
    public GameObject Slingshot;
    Vector3 v;
    public GameSlingshotMove L;
    public bool pull = false;
    public Mouse mouse;
    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (mouse.pull)
        {
            v = L.vL - Slingshot.transform.position;
            liner.SetPosition(1, v);
        }
        else
        {
            liner.SetPosition(1, Vector3.zero);
        }

    }
}
