using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    public void OnBrokenPlayClick() {
        SceneManager.LoadScene("MainScene");  
    }

    public void OnCorrectPlayClick() {
        SceneManager.LoadScene("Final");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
