using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnpilihanmenu : MonoBehaviour
{
    public GameObject PilihanMenu;
    public GameObject InformasiTombol;
    // Start is called before the first frame update
    void Start()
    {
        PilihanMenu.SetActive(true);
        InformasiTombol.SetActive(false);    
    }
public void btninformasiClicked()
{
    PilihanMenu.SetActive(false);
        InformasiTombol.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
