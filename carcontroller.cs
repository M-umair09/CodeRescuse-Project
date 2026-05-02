using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class carcontroller : MonoBehaviour
{
    
   public float speed = 8.0f;
    public float turnSpeed = 5.0f;
    public float forwradInput;
    public float horzntalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        forwradInput = Input.GetAxis("Vertical");
        horzntalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwradInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horzntalInput);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Stone"))
        {
            gamemanager.instance.GameOver();
            Debug.Log("GameOver");
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        //EndPoint
        if(other.CompareTag("EndPoint"))
        {
            Debug.Log("endpoint");
           gamemanager.instance.win();

        }
        if(other.CompareTag("Coin"))
        {
            gamemanager.instance.ScoreIncrement();
           
            Debug.Log("coins");
            Destroy(other.gameObject);
            //score add
        }
        //Debug.Log("trigger working");
        //Destroy(other.gameObject);

    }

    
    
}






















  /*public float speed=20.0f;
    public float turnSpeed=45.0f;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    horizontalInput=Input.GetAxis("Horizontal");
    forwardInput=Input.GetAxis("Vertical");
   // transform.Translate(0,0,1);//1st step
   // transform.Translate(Vector3.forward);//2nd step
       // transform.Translate(Vector3.forward*Time.deltaTime*20);//3rd step
      // transform.Translate(Vector3.forward*Time.deltaTime*speed);//4th step
       transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);//final
      // transform.Translate(Vector3.right*Time.deltaTime*turnSpeed);
      // transform.Translate(Vector3.right*Time.deltaTime*turnSpeed*horizontalInput);
       transform.Rotate(Vector3.up*turnSpeed*horizontalInput*Time.deltaTime);//final
    }
    void OnCollisionEnter(Collision collision)
    {
    if(collision.gameObject.CompareTag("obstacle"))
    {
        Debug.Log("Collider");
    }
    }
    void OnTriggerEnter(Collider other)
    {
    if(other.CompareTag("Coin"))
    {
    Destroy(other.gameObject);
   
    Debug.Log("trigger");
    
    }
    }*/
