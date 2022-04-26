using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    //public Vector3 pos;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += new Vector3(0,0.01f*speed,0);
        Debug.Log("My position is " )
    }
    public void MoveUpward()
    {
        
    }
}
