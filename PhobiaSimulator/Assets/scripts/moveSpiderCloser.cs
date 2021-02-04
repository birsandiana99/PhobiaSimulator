using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//var speed = 0.07;
public class moveSpiderCloser : MonoBehaviour
{
    public Animator anim;
    public Vector3 initialPos;
    // Start is called before the first frame update
    void Start()
    {

        anim.SetBool("isWaking", false);
        initialPos = transform.position;
        //anim = GameObject.GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        var distance = 5;
        //anim.SetBool("isWaking", transform.position.z >= 4);
        //while (Input.GetKeyDown(KeyCode.E)) {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = initialPos;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("scene-1");
        }

        if (transform.position.z >= 4)
        {
            // if (Input.GetKeyDown(KeyCode.E))
            //  {
            anim.SetBool("isWaking", true);
            transform.position = transform.position - GameObject.Find("fence_double").transform.forward * distance *2  * Time.deltaTime;
            //  }
        }
        else
        {
            StartCoroutine(LoadScene3(3));
            
        }
    //}
        


    }

    private IEnumerator LoadScene3(float v)
    {
        yield return new WaitForSeconds(v);
        SceneManager.LoadScene("scene-3");
    }
}
