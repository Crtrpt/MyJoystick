using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    List<Object> knapsack;

    /**
     * 技能列表
     */
    List<Object> skill;

    /**
     * 角色主体
     */
    public GameObject body;

    public Button f1;

    public Button f2;

    public Button f3;

    public Animator animator;

    public VariableJoystick variableJoystick;

    public Text testText;


    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //Debug.Log("h"+h+"  v:"+v);

        h = h == 0 ? variableJoystick.Horizontal : h;
        v = v == 0 ? variableJoystick.Vertical : v;
        //运动

        
        if (v != 0 && h!=0)
        {
            animator.SetBool("run", true);
            animator.speed = 0.5f+Mathf.Abs(v);
        }
        else {
            animator.SetBool("run", false);
        }

       var a = body.transform.rotation;

       
        if (v >= 0)
       {
            a.y = 0;
            a.x = 0;
            a.z = 0;
        }
        else {
            a.y = 180;
            a.x = 0;
            a.z = 0;
        }
           

        body.transform.rotation = a;
        testText.text = "v" + v + "  h:" + h + " a ";
    }

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("初始化角色 属性");
        this.f2.onClick.AddListener(Attach);
        this.f3.onClick.AddListener(Jump);
    }

    void Attach()
    {
        //攻击
        animator.SetBool("attack", !animator.GetBool("attack"));
        Debug.Log("Attach" + animator.GetBool("attack"));
    }

    void Jump()
    {
        //跳跃

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
