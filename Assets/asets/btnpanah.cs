using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnpanah : MonoBehaviour
{
    public GameObject InformasiTombol;
    public GameObject PilihanMenu;
    // Start is called before the first frame update
    void Start()
    {
        InformasiTombol.SetActive(true);
        PilihanMenu.SetActive(false);   
    }
public void btnpanahClicked()
{
    InformasiTombol.SetActive(false);
        PilihanMenu.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
