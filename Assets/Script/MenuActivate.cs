using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActivate : MonoBehaviour
{
    public GameObject Menu;


    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Menu.activeInHierarchy)
            {
                Menu.SetActive(false);
            }
            else{
                Menu.SetActive(true);
            }
               
        }

    }

}
