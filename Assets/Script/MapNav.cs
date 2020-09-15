using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

 void Update()
 {
     if (Input.GetKey(KeyCode.RightArrow))
     {
         transform.Translate(Vector2.right * Time.deltaTime);
     }
     if (Input.GetKey(KeyCode.LeftArrow))
     {
         transform.Translate(Vector2.left * Time.deltaTime);
     }


 }
}
