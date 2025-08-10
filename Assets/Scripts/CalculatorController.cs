using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalculatorController : MonoBehaviour
{
    public TextMeshProUGUI resultText, allResultText;
    private string operation;
    private float number1, number2;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Write0()
    {
        if (resultText.text == Convert.ToString("0")) 
        {
            resultText.text = "0";
        }
        else
        {
            resultText.text += "0";
        }
    }
    public void Write1()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "1";
        }
        else
        {
            resultText.text += "1";
        }
    }
    public void Write2()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "2";
        }
        else
        {
            resultText.text += "2";
        }
    }
    public void Write3()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "3";
        }
        else
        {
            resultText.text += "3";
        }
    }
    public void Write4()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "4";
        }
        else
        {
            resultText.text += "4";
        }
    }
    public void Write5()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "5";
        }
        else
        {
            resultText.text += "5";
        }
    }
    public void Write6()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "6";
        }
        else
        {
            resultText.text += "6";
        }
    }
    public void Write7()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "7";
        }
        else
        {
            resultText.text += "7";
        }
    }
    public void Write8()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "8";
        }
        else
        {
            resultText.text += "8";
        }
    }
    public void Write9()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "9";
        }
        else
        {
            resultText.text += "9";
        }
    }
    public void AllClear()
    {
        resultText.text = "0";
        allResultText.text = "";
    }
    public void Back()
    {
        if (resultText.text.Length > 1)//String'in uzunluğu 1'den büyükse
        {
            resultText.text = resultText.text.Remove(resultText.text.Length - 1, 1);//Son rakamı siler
        }
        else 
        {
            resultText.text = "0";
        }
    }
    public void Addition()
    {
        number1 = float.Parse(resultText.text);
        operation = "+";
        allResultText.text = number1 + " + ";
        resultText.text = "0";
    }
    public void Subtraction()
    {
        number1 = float.Parse(resultText.text);
        operation = "-";
        allResultText.text = number1 + " - ";
        resultText.text = "0";
    }
    public void Multiplication()
    {
        number1 = float.Parse(resultText.text);
        operation = "x";
        allResultText.text = number1 + " x ";
        resultText.text = "0";
    }
    public void Division()
    {
        number1 = float.Parse(resultText.text);
        operation = "÷";
        allResultText.text = number1 + " ÷ ";
        resultText.text = "0";
    }
    public void Remaining()
    {
        number1 = float.Parse(resultText.text);
        operation = "%";
        allResultText.text = number1 + " % ";
        resultText.text = "0";
    }
    public void Equals()
    {
        number2 = float.Parse(resultText.text);
        if (operation == "+")
        {
            resultText.text = (number1 + number2).ToString();//Sonucu yazdırır
            allResultText.text = number1 + " + " + number2 + " = ";
        }
        if (operation == "-") 
        {
            resultText.text = (number1 - number2).ToString();
            allResultText.text = number1 + " - " + number2 + " = ";
        }
        if (operation == "x")
        {
            resultText.text = (number1 * number2).ToString();
            allResultText.text = number1 + " x " + number2 + " = ";
        }
        if (operation == "÷") 
        {
            resultText.text = (number1 / number2).ToString();
            allResultText.text = number1 + " ÷ " + number2 + " = ";
        }
        if (operation == "%")
        {       
            resultText.text = (number1 % number2).ToString();
            allResultText.text = number1 + " % " + number2 + " = ";
        }
    }
    public void NumberSign()
    {
        number1 = float.Parse(resultText.text);
        number1 *= -1;
        resultText.text = number1.ToString();
    }
    public void DecimalNumber()
    {
        if (!resultText.text.Contains(","))
        {
            resultText.text += ",";
        }
    }
    public void ReverseNumber() 
    {    
        number1 = float.Parse(resultText.text);
        allResultText.text = "1/" + number1 + " = ";
        resultText.text = (number1 = 1 / number1).ToString();    
    }
    public void Exponentiation()
    {
        number1 = float.Parse(resultText.text);
        allResultText.text = number1 + "^2 = ";
        resultText.text = (number1 *= number1).ToString();
    }
    public void Sqrt()
    {
        number1 = float.Parse(resultText.text);
        allResultText.text = "√" + number1 +" = ";
        resultText.text = Math.Sqrt(number1).ToString();       
    }
}
