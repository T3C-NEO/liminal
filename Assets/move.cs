using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public CharacterController chara;
    Vector3 warpPosition;
    Vector3 moove = new Vector3(0, 0, 0.5f);


    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        
        if (chara.isGrounded == false)
        {
            //Add our gravity Vecotr
            moove += Physics.gravity;
        }

        chara.Move(moove * Time.deltaTime * speed);

    }
}
