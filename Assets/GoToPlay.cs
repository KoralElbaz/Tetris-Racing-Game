using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToPlay : MonoBehaviour
{
    [SerializeField] string sceneName;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
        }
    }
}
