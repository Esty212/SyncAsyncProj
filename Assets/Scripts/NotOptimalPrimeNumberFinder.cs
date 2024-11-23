using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class NotOptimalPrimeNumberFinder : MonoBehaviour
{
    [SerializeField] private Button _activationButton;
    [SerializeField] private InputField _inputField;
    [SerializeField] private TextMeshProUGUI  _textField;

    private void Awake()
    {
        _activationButton.onClick.AddListener(OnClick);
    }


    private void OnClick()
    {
        if (int.TryParse(_inputField.text, out int index))
        {
            var  primeNumber = FindPrimeNumberAtIndex(index);
            _textField.text = primeNumber.ToString();
        }
        
        _inputField.text = string.Empty;
    }
    
    private int FindPrimeNumberAtIndex(int index)
    {
        int primeNumber = 1;
        int count = 0;
        while (count < index)
        {  
            primeNumber++;
            if (IsPrime(primeNumber))
            {
                count++;
            }
        }

        return primeNumber;
    }
    
    private bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }
        
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

   
}