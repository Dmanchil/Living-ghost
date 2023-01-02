using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour
{

    [SerializeField] GameObject camera;
    //
     int movezplus = 0;
     int movezminuse = 0;
     int movexplus = 0;
     int movexminuse = 0;
    //
    [SerializeField] int speed;
    Vector3 Vector3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
    //Move if
        //movezplus
        if (Input.GetKeyDown(KeyCode.W))
        {
            //transform.position = transform.position + new Vector3(0, 0, speed);
            movezplus = 1;
        }
        else
        {
            movezplus = 0;
        }
        //movezminuse
        if (Input.GetKeyDown(KeyCode.S))
        {
            //transform.position = transform.position + new Vector3(0, 0, -speed);
            movezminuse = 1;
        }
        else
        {
            movezminuse = 0;
        }
        //
        //movexplus
        if (Input.GetKeyDown(KeyCode.D))
        {
            //transform.position = transform.position + new Vector3(0, 0, -speed);
            movexplus = 1;
        }
        else
        {
            movexplus = 0;
        }
        //
        //movexminuse
        if (Input.GetKeyDown(KeyCode.A))
        {
            //transform.position = transform.position + new Vector3(0, 0, -speed);
            movexminuse = 1;
        }
        else
        {
            movexminuse = 0;
        }
        //
    //move if//
    //Move
        //movezplus
        if(movezplus == 1){
        transform.position = transform.position + new Vector3(0, 0, speed);
        }
        //
        //movezminuse
        if(movezminuse == 1){
        transform.position = transform.position + new Vector3(0, 0, -speed);
        }
        //
        //movexplus
        if(movexplus == 1){
        transform.position = transform.position + new Vector3(speed, 0, 0);
        }
        //
        //movexminuse
        if(movexminuse == 1){
        transform.position = transform.position + new Vector3(-speed, 0, 0);
        }
        //
    }
}
