using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public static void LodeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
