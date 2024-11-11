using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{

    private TextMeshProUGUI seivaText;

    // Start is called before the first frame update
    void Start()
    {
        seivaText = GetComponent<TextMeshProUGUI>();
        
    }

    public void UpdateSeivaText(PlayerInventory playerInventory)
    {
        seivaText.text = playerInventory.NumberOfSeiva.ToString();
    }
}
