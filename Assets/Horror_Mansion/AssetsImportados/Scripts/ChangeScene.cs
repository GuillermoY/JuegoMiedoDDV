using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] Button loadButton;
    void Start()
    {
        loadButton.onClick.Invoke();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;     // set to default default
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
