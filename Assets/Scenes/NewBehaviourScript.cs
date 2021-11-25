using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject sphere;
  
    void Start()
    {
       /** Button b = gameObject.GetComponent<Button>();
        sphere = GameObject.Find("Sphere");
       
        b.onClick.AddListener(delegate () {
            GameObject s = Instantiate(sphere) as GameObject;

          
               var p= s.transform.position;
                p.y = 3;
                p.z = 0.1F;
                s.transform.position = p;
        });
        **/
       
    }

    private void OnMouseDown()
    {
       
    }
}
