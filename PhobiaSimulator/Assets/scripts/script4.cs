using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script4 : MonoBehaviour
{

    // Start is called before the first frame update
    #region "Variables"
    float inputZ, inputX;
    private bool jump;
    public Animator anim = null;
    #endregion
    void Start()
    {
        Debug.Log("XXXXXXXXXXXXXXXX");
        anim = GetComponent<Animator>();
        if (anim != null) jump = anim.GetBool("jump");
    }


    void Update()
    {
        Debug.Log("XXXXXXXXXXXXXXXX");

        inputZ = Input.GetAxis("Vertical");
        inputX = Input.GetAxis("Horizontal");

        if (inputZ != 0)
        {
            move();
        }
        if (inputX != 0)
        {
            leftright();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (anim != null) anim.SetBool("jump", jump);
        }
        else
        {
            if (anim != null) jump = anim.GetBool("jump");
        }

        Debug.Log(transform.position.z);
        if (transform.position.z >= 0)
        {
            Debug.Log("YEEEEEEET");
            StartCoroutine(LoadScene1(3));
        }
    }
    private void leftright()
    {
        transform.Rotate(new Vector3(0f, inputX * Time.deltaTime * 10, 0f));
    }

    private void move()
    {
        transform.position += transform.forward * inputZ * 4 * Time.deltaTime; //backwards or fowrads
    }

    private IEnumerator LoadScene1(float v)
    {
        yield return new WaitForSeconds(v);
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAS");
        SceneManager.LoadScene("scena4");
        Debug.Log("BBBBBBBBBBBBBBBBBBBBBB");
    }
}
