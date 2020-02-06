using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    public int scene;
    public bool death;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            if(death)
            {
                GameObject.FindGameObjectWithTag("music").GetComponentInChildren<SFX>().Die();
            }
            SceneManager.LoadScene(scene);
        }

    }

}
