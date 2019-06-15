using UnityEngine;
using System.Collections;

public class LineBG : MonoBehaviour {

    public BGScript BG;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (BG.step == 1)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Destroy(transform.GetChild(i).gameObject);
            }
        }
    }
}
