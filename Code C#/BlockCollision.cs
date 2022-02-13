using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockCollision : MonoBehaviour
{
    public BoxCollider2D coll;                 //We declare a BoxCollider2D object to handle object collisions
    public CircleCollider2D ball;

    public bool collision;                     //Boolean variable

    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        collision = false;                      //we initialize collision to false
    }

    // Update is called once per frame
    void Update()
    {                                           //we assign the value of the IsTouching function to the Boolean variable collision
        collision = coll.IsTouching(ball);      //which returns true if it has detected a collision if not it returns false
        if (collision ==true){                   
            Destroy(gameObject);                //if collision is equal to true we destroy the object

        }
        
    }
}
