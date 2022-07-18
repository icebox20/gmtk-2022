using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    static int Health = 0;
    static int Ammo = 0;
    public TextMeshProUGUI ReadoutDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DiePressed(string dieName)
    {
        ReadoutDisplay.SetText("Dice Name: " + dieName + "\n\nHealth: {0}\n\nAmmo Range: 1-{1}", Health, Ammo);
    }

    public void DiePressedHealth (int dieHealth)
    {
        Health = dieHealth;
    }
    
    public void DiePressedAmmo (int dieAmmo)
    {
        Ammo = dieAmmo;
    }
}
