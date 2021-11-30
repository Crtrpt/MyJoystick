using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leftJoystick : MonoBehaviour
{

    public VariableJoystick variableJoystick;

    public Text testText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("leftJoystick init");
    }


    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //Debug.Log("h"+h+"  v:"+v);

        h = h == 0 ? variableJoystick.Horizontal : h;
        v = v == 0 ? variableJoystick.Vertical : v;
        testText.text = "v" + v + "  h:" + h;
    }
}
