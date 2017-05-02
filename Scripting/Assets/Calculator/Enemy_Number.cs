using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Number : MonoBehaviour {
    public Enemy_List E;
    public float Enemy_Num;
    public Total T;
    Text text;

    
    void Start () {

        text = GetComponent<Text>();
        E.enemy.Add(Enemy_Num);
        text.text = Enemy_Num.ToString();
    }

    void Update()
    {
        transform.Translate(0f , -5f* Time.deltaTime, 0f);
        if (T.total == Enemy_Num)
            Destroy(gameObject);
        if (transform.position.y <= (-51))
        {
            print("You Failed");
        }

    }
}
