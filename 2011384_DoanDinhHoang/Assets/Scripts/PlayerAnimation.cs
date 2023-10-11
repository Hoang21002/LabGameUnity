using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animation _animation;
    // Start is called before the first frame update
    void Start()
    {
        _animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        if (v > 0)
        {
            _animation.Play("RunForward");
        }
        else if (v < 0)
        {
            _animation.Play("RunBackward");
        }

        float h = Input.GetAxis("Horizontal");

        if (h > 0)
        {
            _animation.Play("RunRight");
        }
        else if (h < 0)
        {
            _animation.Play("RunLeft");
        }
        if (v == 0 && h == 0) _animation.Play("Idle");
    }
}
