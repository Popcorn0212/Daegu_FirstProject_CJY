using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze2 : SwordMan
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public override void Move()
    {
        // 부모의 Move 함수를 실행한다.
        base.Move();
        print("척척척 하면서 발자국 소리를 냅니다.");
    }
}
