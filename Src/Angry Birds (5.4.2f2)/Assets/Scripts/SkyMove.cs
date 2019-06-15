using UnityEngine;
using System.Collections;

public class SkyMove : MonoBehaviour {

    public GameObject Sky1;
    public GameObject Sky2;
    public float moveSpeed = 1;
    public float SimpleDistance = 0;
    public float removePosition = 0;
	// Update is called once per frame
	void Update ()
    {
        Sky1.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        if (Sky1.transform.position.x < removePosition)
        {
            Sky1.transform.position = Sky2.transform.position + new Vector3(SimpleDistance, 0,0);
        }
    }
}
