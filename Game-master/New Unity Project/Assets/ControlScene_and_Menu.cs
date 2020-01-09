using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScene_and_Menu : MonoBehaviour
{
    public GameObject buttonsMenu;
    public GameObject buttonsExit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowExitButtons()
    {
        buttonsMenu.SetActive(false);
        buttonsExit.SetActive(true);
    }
}
