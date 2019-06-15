using UnityEngine;
using System.Collections;

public class Bexplosion : MonoBehaviour
{
    public int Force;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Rigidbody2D>() != null)
        {
            Vector2 v2 = (collision.transform.position - gameObject.transform.position).normalized;
            float l = 5 - v2.magnitude;
            collision.GetComponent<Rigidbody2D>().AddForce(v2 * l * Force, ForceMode2D.Force);
        }
           
        
    }
}
