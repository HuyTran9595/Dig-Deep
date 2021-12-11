using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    [SerializeField]
    GameObject Logo;

    [SerializeField]
    GameObject Op_Menu;

    [SerializeField]
    GameObject Le_Menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Options()
    {
        Logo.SetActive(false);
        Op_Menu.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void L_Select()
    {
        Logo.SetActive(false);
        Le_Menu.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
