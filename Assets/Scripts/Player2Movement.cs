using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player2Movement : MonoBehaviour
{
    public Vector3 _rotation ;
    public float rotation_speed = 10f;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var h = CrossPlatformInputManager.GetAxis("Horizontal");
        var v = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(h, 0, v) ;
        transform.position -= moveVector * Time.deltaTime *  speed;

        if (moveVector != Vector3.zero)
        {
            _rotation = new Vector3(Random.Range(1.0f, 100.0f), Random.Range(1.0f, 100.0f), Random.Range(1.0f, 100.0f));
            transform.Rotate(_rotation * rotation_speed * Time.deltaTime);
        }
    }

}