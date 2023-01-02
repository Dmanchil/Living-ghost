using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] Text textmoney;
    [SerializeField] int money;
    // Update is called once per frame
    void Update()
    {
        //print(money);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "coal")
        {
            money += 1;
            print("money+");
            Destroy(other.gameObject);
            textmoney.text = money.ToString(); 
        }
    }
}
