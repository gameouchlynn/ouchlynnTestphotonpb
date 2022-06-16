using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float x;
    public float speed;
    private Rigidbody2D rigid;
    public float jp;
    public bool fjp = false;
    
   
   void Start()
    {
        rigid=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x= Input.GetAxis("Horizontal");
        transform.position +=(Vector3) new Vector2(x * speed * Time.deltaTime, 0);
        
    }
    private  void FixedUpdate() 
    {
        if (Input.GetButton("Jump") )
        {
        
            rigid.AddForce(transform.up*jp,ForceMode2D.Impulse);
            
        }

    }
    
}
