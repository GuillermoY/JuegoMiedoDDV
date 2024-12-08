using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgrounRepeat : MonoBehaviour
{
    private Vector3 Po;
    //Po = Posición origen
    float AnchoRep;
    // Start is called before the first frame update
    void Start()
    {
        Po = transform.position;
        AnchoRep = GetComponent<BoxCollider>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > Po.x + AnchoRep)
        {
            transform.position = Po;   
        }
    }
}
