using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToOptionsMenu : MonoBehaviour
{
    public void OpenOptionsMenu() { SceneManager.LoadSceneAsync(2); }
}
