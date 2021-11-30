using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rightJoystick : MonoBehaviour
{
    // Start is called before the first frame update
    public VariableJoystick variableJoystick;

    public Text testText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("leftJoystick init");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float h = 0;
        float v = 0;
        //Debug.Log("h"+h+"  v:"+v);
        h = h == 0 ? variableJoystick.Horizontal : h;
        v = v == 0 ? variableJoystick.Vertical : v;
        testText.text = "v" + v + "  h:" + h;
    }
}
