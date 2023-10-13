using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    Animation _animation;
    void Start()
    {
        _animation = GetComponentInChildren<Animation>();
        string animationToPlay = "";
        switch (Random.Range(0, 3))
        {
            default:
            case 0:
                animationToPlay = "Move1";
                break;
            case 1:
                animationToPlay = "Move2";
                break;
            case 2:
                animationToPlay = "Move3";
                break;
        }
        _animation[animationToPlay].wrapMode = WrapMode.Loop;

        _animation.Play(animationToPlay);

        _animation[animationToPlay].normalizedTime = Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
