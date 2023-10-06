using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GoToSceneMenu();
        }
    }

    void GoToSceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    void GoToSceneRestart()
    {
        SceneManager.LoadScene("Restart");
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f,moveVertical);
        rb.AddForce (movement * speed);
    
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive (false);
            count += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count : " + count.ToString();
        if(count >= 18)
        {
           GoToSceneRestart();

        }

    }
 
}
