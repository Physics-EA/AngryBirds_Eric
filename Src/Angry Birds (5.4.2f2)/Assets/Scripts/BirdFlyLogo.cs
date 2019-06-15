using UnityEngine;
using System.Collections;

public class BirdFlyLogo : MonoBehaviour {

    public GameObject go;

	// Use this for initialization
	void Start ()
    {
        int h = Random.Range(9, 13);
        go.GetComponent<Rigidbody2D>().AddForce(new Vector2(5, h), ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (go.transform.position.y < -6f)
        {
            Destroy(go);
        }
    }
}
