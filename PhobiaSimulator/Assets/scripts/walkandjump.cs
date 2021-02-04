using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class walkandjump : MonoBehaviour
{

    public Animator anim;
    public Vector3 initialPos;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("starttttttttttttttttttttt");
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
            SceneManager.LoadScene("scene_1");
        }
        if (transform.position.z >= 33)
        {
            
            anim.SetBool("run", true);
            transform.position = transform.position - GameObject.Find("here").transform.forward * distance * Time.deltaTime;
          
        }
        else
        {
            anim.SetBool("jump", true);
            
            StartCoroutine(Quit(3));
        }
        

    }

    private IEnumerator Quit(float v)
    {
        yield return new WaitForSeconds(v);
        SceneManager.LoadScene("scene_1");
    }
}
