using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnyukbelajar : MonoBehaviour
{
    public GameObject PilihanMenu;
    public GameObject Materi1;
    // Start is called before the first frame update
    void Start()
    {
        PilihanMenu.SetActive(true);
        Materi1.SetActive(false);   
    }
public void btnbelajarClicked()
{
    PilihanMenu.SetActive(false);
        Materi1.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
