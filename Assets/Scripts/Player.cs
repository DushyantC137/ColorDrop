using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string thisColor;
    public GameObject player;
    Rigidbody2D rb;
    public bool GameOver;
    public SpriteRenderer sr;
    public Color yellow;
    public Color blue;
    public Color red;
    public Color pink;
    public GameObject Camera;
    // Use this for initialization
    
    void Start()
    {
        
        rb= player.GetComponent<Rigidbody2D>();
        //sr = player.GetComponent<SpriteRenderer>();
       thisColor= SetRandomColor();
      //  Debug.Log("RANDOM " + thisColor);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!GameOver)
        {
            if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
            {
               // Debug.Log("click");
                rb.gravityScale = 2f;
               // Debug.Log("thisColor=" + this.thisColor);
            }

        }
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
     //RightColor
        if (col.tag==this.thisColor)
        {
            Debug.Log("coltag " + col.tag + " thiscolor "+thisColor);
            DestroyVillian();
            StopPlayer();

            
        }
        else if (col.tag !=this.thisColor)
        {
     //Wrong Color
            Debug.Log("GameOver");
            Destroy(player);
            Camera.GetComponent<Animator>().Play("CameraShake");
            
        }
     //Color Switch


    }
    string SetRandomColor()
    { 
        int index = Random.Range(0, 3);
        switch (index)
        {
            case 0:
                //      thisColor = "yellow";
                sr.color = yellow;
                return "yellow";
                break;
            case 1:
                //thisColor = "pink";
                sr.color = pink; Debug.Log("thisColor== " + thisColor);
                return "pink";
                break;
            case 2:
                //thisColor = "blue";
                sr.color = blue;
                return "blue";
                break;
            case 3:
                //thisColor = "red";
                sr.color = red;
                return "red";
                break;
            default:
                return "red";
        }
    }
    public void DestroyVillian()
    {
        Debug.Log("Destroyed");
        Destroy(GameObject.FindWithTag("villian"));
    }
    
    public void StopPlayer()
    {
        rb.gravityScale = 0;
        rb.velocity = new Vector2(0,0);
       
    }
}
