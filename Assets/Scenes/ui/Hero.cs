using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using uPLibrary.Networking.M2Mqtt;

public class Hero : MonoBehaviour
{
    /**
     * 攻击值
     */
    public int attack_value;

    /**
     *  攻击距离
     */
    public int attack_distance;

    /**
     * 防御值
     */
    public int defense_value;

    /**
     * 血量
     */
    public int blood_value;

    /**
     * 物品盒子
     *
     */
    List<UnityEngine.Object> knapsack;

    /**
     * 技能列表
     */
    List<UnityEngine.Object> skill;

    /**
     * 角色主体
     */
    public GameObject body;

    public Button f1;

    public Button f2;

    public Button f3;

    public Button f4;

    public Animator animator;

    public VariableJoystick variableJoystick;

    public Text testText;

    public Vector2 source =new Vector2(0,1);


    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //Debug.Log("h"+h+"  v:"+v);

        h = h == 0 ? variableJoystick.Horizontal : h;
        v = v == 0 ? variableJoystick.Vertical : v;
        //运动

        
  

        float angle = 0;

        var to = new Vector2(h, v);
        angle = Vector2.Angle(source, to);
        // > 0.5 表示开始移动
        if (v > 0.5 || h > 0.5)
        {
          

            if (angle < 5 && angle > -5)
            {

            }
            else {
               
         
                body.transform.eulerAngles = new Vector3(
                body.transform.eulerAngles.x,
                body.transform.eulerAngles.y + angle,
                body.transform.eulerAngles.z);
                //source = to;

            }

           
        }


        if (v != 0)
        {
            animator.SetBool("run", true);
            animator.speed = 0.5f + Math.Max(Mathf.Abs(v), Math.Abs(h));
            body.transform.Translate(body.transform.forward * 10 * Time.deltaTime);
        }
        else
        {
            animator.SetBool("run", false);
        }





        testText.text = "v" + v + "  h:" + h + " a " + angle+" source x:"+source.x+" source y:"+source.y+" to x:"+to.x+" to y:"+to.y;

    }


    private void Rotate(Transform t,float h,float v,float s) {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        var m = new MqttClient("broker.emqx.io");
        m.Connect("unity");
        if (!m.IsConnected)
        {
            Debug.Log("失败");
        }
        m.Publish("/unity", System.Text.Encoding.Default.GetBytes("hello"));
        Debug.Log("初始化角色 属性");
        this.f2.onClick.AddListener(Attach);
        this.f3.onClick.AddListener(Jump);
        this.f4.onClick.AddListener(Rotate);

    }

    private void Rotate()
    {

       

       
        float angle = Vector2.Angle(new Vector2(0,1), new Vector2(-1,0 ));
        Debug.Log("角度" + angle);

        var angle1 = Vector2.Angle(new Vector2(0, 1), new Vector2(0, -1));
        Debug.Log("F角度2" +  angle1);

    }

    void Attach()
    {
        //攻击
        animator.SetBool("attack", !animator.GetBool("attack"));
        Debug.Log("Attach" + animator.GetBool("attack"));
    }

    void Jump()
    {
        //跳跃 抛物线

        var postion = this.body.transform.position;
        postion.y = 1;
        this.body.transform.position = postion;
        Debug.Log("Attach" + animator.GetBool("attack"));
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
