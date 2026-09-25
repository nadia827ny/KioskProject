using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{


    public void OpenScene1()
    {
        SceneManager.LoadScene("Scene1");

    }
    public void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OpenScene2()
    {
        SceneManager.LoadScene("Scene2");

    }

    public void OpenScene3()
    {
        SceneManager.LoadScene("Scene3");

    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
