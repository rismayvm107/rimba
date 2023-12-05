using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btncome3 : MonoBehaviour
{
    public GameObject Materi4;
    public GameObject TampilanAwal;
    // Start is called before the first frame update
    void Start()
    {
         Materi4.SetActive(true);
        TampilanAwal.SetActive(false); 
    }
public void btnsilangClicked()
{
    Materi4.SetActive(false);
        TampilanAwal.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
