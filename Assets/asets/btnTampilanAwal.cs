using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnTampilanAwal : MonoBehaviour
{
    public GameObject TampilanAwal;
    public GameObject PilihanMenu;
    // Start is called before the first frame update
    void Start()
    {
        TampilanAwal.SetActive(true);
        PilihanMenu.SetActive(false);
    }
public void btnmulaiClicked()
{
    TampilanAwal.SetActive(false);
        PilihanMenu.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
