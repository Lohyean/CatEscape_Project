using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 왼쪽 화살표가 눌렸을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0); // 왼쪽으로 3 움직인다.
        }

        // 오른쪽으로 화살표가 눌렸을 때
        if(Input.GetKeyDown(KeyCode.RightArrow))
        { 
            transform.Translate(1, 0, 0); // 오른쪽으로 3 움직인다.
        }

    }
}
