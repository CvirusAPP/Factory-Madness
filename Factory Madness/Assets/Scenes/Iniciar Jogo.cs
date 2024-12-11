using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJogo : MonoBehaviour
{
   public void iniciarJogo()
   {
       SceneManager.LoadScene("jogo");
   }
}
