using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyForward;
    [SerializeField] KeyCode keyBack;
    [SerializeField] Vector3 moveDirection;
    public int coins;
    public TMP_Text TextCoins;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            coins = PlayerPrefs.GetInt("Coins");
            TextCoins.text = "Score:  " + coins.ToString();
        }
    }

    private void FixedUpdate()  
    {

        if (Input.GetKey(keyForward)) 
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(keyBack))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.gameObject.tag == "Bonus")
        {
            coins++;
            other.gameObject.SetActive(false);
            TextCoins.text = "Score:  " + coins.ToString();
            PlayerPrefs.SetInt("Coins", coins);
        }
    }
}
