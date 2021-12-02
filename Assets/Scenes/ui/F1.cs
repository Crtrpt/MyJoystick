using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class F1 : MonoBehaviour
{
    public Button f1;

    public Button f2;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        this.f1.onClick.AddListener(Run);
        this.f2.onClick.AddListener(Attach);
    }

    void Attach()
    {
        //Output this to console when Button1 or Button3 is clicked

        animator.SetBool("attack", !animator.GetBool("attack"));
        Debug.Log("Attach" + animator.GetBool("attack"));
    }

    void Run()
    {
        //Output this to console when Button1 or Button3 is clicked
    
        animator.SetBool("run", !animator.GetBool("run"));
        Debug.Log("Click"+ animator.GetBool("run"));
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
