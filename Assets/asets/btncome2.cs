using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btncome2 : MonoBehaviour
{
    public GameObject PilihanMenu;
    public GameObject TampilanAwal;
    // Start is called before the first frame update
    void Start()
    {
        PilihanMenu.SetActive(true);
        TampilanAwal.SetActive(false);    
    }
public void btnsilangClicked() 
{
    PilihanMenu.SetActive(false);
        TampilanAwal.SetActive(true);
} 
// Update is called once per frame
    void Update()
    {
        
    }
    }
    
