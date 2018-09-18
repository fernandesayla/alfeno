using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {
    public int pontos = 100;

    [SerializeField]
    private Text txtPontuacao;

    public  void AdicionarPontuacao(){
        this.pontos--;
        this.txtPontuacao.text = this.pontos.ToString(); 
    }
}
