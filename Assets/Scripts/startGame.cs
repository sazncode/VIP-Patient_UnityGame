using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BEGIN();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BEGIN()
    {
        SceneManager.LoadScene("GAME");
    }
}
