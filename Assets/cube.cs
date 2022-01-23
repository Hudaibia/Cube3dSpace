using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public float scale = .01f;
    public float turnspeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {

       
        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale = transform.localScale + new Vector3(scale, scale, scale);

        }
        else if (transform.localScale.x > 1 && transform.localScale.y > 1 && transform.localScale.z > 1 )

        {
            transform.localScale = transform.localScale + new Vector3(-scale, -scale, -scale);

        }










       transform.Rotate(Vector3.up * turnspeed * Input.GetAxis("Horizontal") * Time.deltaTime );
        

      
    }
}
