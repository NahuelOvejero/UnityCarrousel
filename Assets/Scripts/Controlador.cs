using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour {


    public class Diapositiva{
        public string Titulo;
        public string Descripcion;
        public string Fotografia;
        public Diapositiva(string _titulo, string desc, string path) {
            Titulo = _titulo;
            Descripcion = desc;
            Fotografia = path;
        }

    }
    public Text Titulo;
    public Text Descripcion;
    public Image Fotografia;
    //Resources.Load<Sprite>("imagenes/Everest");

    int indice = 0;
    public List<Diapositiva> MisDiapos = new List<Diapositiva>();


	// Use this for initialization
	void Start () {
        MisDiapos.Add(new Diapositiva("Everest","La montaña mas grande del mundo. 8.848 metros","imagenes/Everest"));
        MisDiapos.Add(new Diapositiva("K2", "La segunda montaña mas grande del mundo. 8.611 metros", "imagenes/K2"));
        MisDiapos.Add(new Diapositiva("Kangchenjunga", "La montaña mas grande del mundo. 8.584 metros", "imagenes/Kangchenjunga"));
        MisDiapos.Add(new Diapositiva("Lhotse", "La montaña mas grande del mundo. 8.516 metros", "imagenes/Lhotse"));
        actualizar();

    }
	
	// Update is called once per frame
	void Update () {
  
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) {
            adelante();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            atras();
        }
        actualizar();
      
    }

    private void adelante() {
        if (indice >= 3)
        {
            indice = 0;
        }
        else {
            indice++;
        }
    }

    private void atras() {
        if (indice <= 0)
        {
            indice = 3;
        }
        else
        {
            indice--;
        }
    }

    private void actualizar() {
        Titulo.text = MisDiapos[indice].Titulo;
        Descripcion.text = MisDiapos[indice].Descripcion;
        Fotografia.sprite = Resources.Load<Sprite>(MisDiapos[indice].Fotografia);
    }

}
