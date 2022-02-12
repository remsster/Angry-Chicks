using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 3f;

    

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        Vector3 translation = new Vector3(horiz, 0, vert);
        translation *= MovementSpeed * Time.deltaTime;
        transform.Translate(translation);
    }
}
