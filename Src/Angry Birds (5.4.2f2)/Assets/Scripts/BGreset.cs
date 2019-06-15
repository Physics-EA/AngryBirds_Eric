using UnityEngine;
using System.Collections;

public class BGreset : MonoBehaviour {

    public BGScript BG;
    public GameObject pig;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void closeAndReset()
    {
        BG.step = 1;
        BG.start = true;
        pig.SetActive(true);
        pig.transform.position = new Vector3(1.37f, -0.38f,0);
        pig.transform.rotation = new Quaternion(0,0,0,0);
        BG.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
