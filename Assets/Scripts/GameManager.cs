using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TMP_Text OrganicNumeroText;
    public GameObject objectToActivate;
     public TMP_Text BottleNumeroText;
      public TMP_Text GlassNumeroText;

    // Start is called before the first frame update

    private int OrganicN;
    private int BottleN;
    private int GlassN;

    public void AddOrganic()
    {
        OrganicN = OrganicN + 1;

        OrganicNumeroText.text = OrganicN.ToString();
        if(OrganicN >= 2)
        {
            ActivateObject();
        }

    }
    void ActivateObject()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true); // Activate the GameObject
        }
    }
    public void AddBottle()
    {
        BottleN = BottleN + 1;

        BottleNumeroText.text = BottleN.ToString();
    }
    public void AddGlass()
    {
        GlassN = GlassN + 1;

        GlassNumeroText.text = GlassN.ToString();
    }
}
