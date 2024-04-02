using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMeshProController : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    

    public void SetText(string inputText)
    {
        // Konversi inputText ke angka 1
        //int number = 1;

        // Ubah angka menjadi string dan atur sebagai teks TextMeshPro
        textMeshPro.text = inputText;
    }
}
