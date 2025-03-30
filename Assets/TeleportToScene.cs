using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class TeleportToScene : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Teleport"))
        {

            SceneManager.LoadScene("SampleScene"); 
        }
    }
}