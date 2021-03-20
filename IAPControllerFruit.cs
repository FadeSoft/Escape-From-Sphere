using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IAPControllerFruit : MonoBehaviour, IStoreListener
{

    IStoreController controller;
    public string[] product;
    public Text cointext;
    public Text epintext;

    public bool delete = true;

    public InputField inputfield;
    public GameObject inputpnl;

    public GameObject CountDownSc;




    private void Start()
    {

        Value = PlayerPrefs.GetInt("mypara");
        CoinAmount.text = "" + CoinAmount;


        IAPStart();
    }


    private void IAPStart()
    {
        var module = StandardPurchasingModule.Instance();

        ConfigurationBuilder builder = ConfigurationBuilder.Instance(module);

        foreach (string item in product)
        {
            builder.AddProduct(item, ProductType.Consumable);
        }
        UnityPurchasing.Initialize(this, builder);






    }
    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        this.controller = controller;
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("Error" + error.ToString());
    }
    public void OnPurchaseFailed(Product i, PurchaseFailureReason p)
    {
        Debug.Log("Error while buying" + p.ToString());

    }
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
    {
        // satın alma gerçekleştiği zaman aktif olacak fonksiyon

        if (string.Equals(e.purchasedProduct.definition.id, product[0], StringComparison.Ordinal))
        {
            //element 0 ı aldıgın zaman

            Add50Altin();
            return PurchaseProcessingResult.Complete;

        }
        else if (string.Equals(e.purchasedProduct.definition.id, product[1], StringComparison.Ordinal))
        {
            //element 1 ı aldıgın zaman
            Add60Altin();
            return PurchaseProcessingResult.Complete;

        }
        else if (string.Equals(e.purchasedProduct.definition.id, product[2], StringComparison.Ordinal))
        {
            //element 2 ı aldıgın zaman
            Add70Altin();

            return PurchaseProcessingResult.Complete;
        }
        else if (string.Equals(e.purchasedProduct.definition.id, product[3], StringComparison.Ordinal))
        {
            //element 3 ı aldıgın zaman
            Add100Altin();

            return PurchaseProcessingResult.Complete;
        }
        else if (string.Equals(e.purchasedProduct.definition.id, product[4], StringComparison.Ordinal))
        {
            //element 4 ı aldıgın zaman
            Add200Altin();

            return PurchaseProcessingResult.Complete;
        }
        else
        {
            return PurchaseProcessingResult.Pending;

        }
    }
    private void AddCoin(int coin)
    {
        cointext.text = coin.ToString() + " altın satın aldı";

        Add50Altin();

    }


    public void IAPButton(string id)
    {
        Product proc = controller.products.WithID(id);
        if (proc != null && proc.availableToPurchase)
        {
            Debug.Log("Buying...");
            controller.InitiatePurchase(proc);

        }
        else
        {
            Debug.Log("Not ");
        }
    }
    /////////////////////////////
    ///
    public int Value;
    public Text CoinAmount;


    public int My_Money;
    public GameObject MoneyEnoughTxt;

    void Update()
    {
        CoinAmount.text = "" + Value;

    }


    public void Add50Altin()
    {
        Value += 50;
        PlayerPrefs.SetInt("mypara", Value);
        cointext.text = "50 ALTIN SATIN ALINDI";
    }

    public void Add60Altin()
    {
        Value += 60;
        PlayerPrefs.SetInt("mypara", Value);
        cointext.text = "60 ALTIN SATIN ALINDI";
    }
    public void Add70Altin()
    {
        Value += 70;
        PlayerPrefs.SetInt("mypara", Value);
        cointext.text = "70 ALTIN SATIN ALINDI";
    }
    public void Add100Altin()
    {
        Value += 100;
        PlayerPrefs.SetInt("mypara", Value);
        cointext.text = "100 ALTIN SATIN ALINDI";
    }
    public void Add200Altin()
    {
        Value += 200;
        PlayerPrefs.SetInt("mypara", Value);
        cointext.text = "200 ALTIN SATIN ALINDI";
    }

    public void Add500Altin()
    {
        Value += 500;
        PlayerPrefs.SetInt("mypara", Value);

    }
    public void Add10000Altin()
    {
        Value += 100000;
        PlayerPrefs.SetInt("mypara", Value);

    }

    public void GiveCoin()
    {


        if (Value >= 20)
        {
            Value -= 20;

            PlayerPrefs.SetInt("mypara", Value);
            CountDownSc.GetComponent<CountDownMeteor>().zamanarttı();



        }
        else if (Value < 20)
        {
            MoneyEnoughTxt.SetActive(true);

        }


    }
    public void DontGiveCoin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = 1;
    }


    public void artırsüre()
    {
        CountDownSc.GetComponent<CountDownMeteor>().zamanarttı();

    }

    public void epinkullan()
    {
        if (inputfield.text == "xUrPTd8%bbC7nOguc9aSf4iPUTK")
        {
            Add10000Altin();
            epintext.text = " E-PİN KULLANILDI. ALINAN ALTIN SAYISI: 100.000";
            inputpnl.SetActive(false);
        }
        else if (inputfield.text == "Ir#MQGyu3p@If4PV!O$Y4iNQo63")
        {
            Add500Altin();
            epintext.text = " E-PİN KULLANILDI. ALINAN ALTIN SAYISI: 500";
            inputpnl.SetActive(false);
        }
        else
            epintext.text = " HATALI GİRİŞ YAPTINIZ.";
    }
    public void epinkullanAC()
    {
        inputpnl.SetActive(true);

    }
}
