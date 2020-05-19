using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public GameObject _menu;
    public GameObject _menuPoints;

    public void OnMouseUp()
    {
        _menu.SetActive(false);
        _menuPoints.SetActive(true);

    }
}
