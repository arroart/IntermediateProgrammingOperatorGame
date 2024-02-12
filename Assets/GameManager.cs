using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    float MoneyLeft = 100f;
    [SerializeField] GameObject moneyText;
    [SerializeField] GameObject productText;
    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        moneyText.GetComponent<TextMeshProUGUI>().text = MoneyLeft.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "BuyableProduct")
            {
                float currentPrice= hit.collider.gameObject.GetComponent<MoneyPrice>().priceObject;
                productText.GetComponent<TextMeshProUGUI>().text = currentPrice.ToString();
                if (Input.GetMouseButtonDown(0))
                {

                    MoneyLeft = (MoneyLeft >= currentPrice) ? MoneyLeft - currentPrice : 0;
                    if (MoneyLeft != 0)
                    {
                        moneyText.GetComponent<TextMeshProUGUI>().text = MoneyLeft.ToString();
                        Destroy(hit.collider.gameObject);
                    }
                    
                }
            }
        }
    }
}
