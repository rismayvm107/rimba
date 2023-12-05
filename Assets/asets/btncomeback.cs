using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btncomeback : MonoBehaviour
{
    public GameObject Materi4;
    public GameObject PilihanMenu;
    // Start is called before the first frame update
    void Start()
    {
        Materi4.SetActive(true);
        PilihanMenu.SetActive(false);    
    }
public void btnmenuClicked()
{
    Materi4.SetActive(false);
        PilihanMenu.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
