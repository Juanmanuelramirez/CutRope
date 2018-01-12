using UnityEngine;

public class RopeCutter : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        //Verficamos si hay colaición con el boton izquierdo del mouse 
		if (Input.GetMouseButton(0))
		{
            //Esta funcion es un rayo que coaliciona, tomara la posicion del mouse 
            //verifica el punto de impacto con la cuerda
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			if (hit.collider != null)
			{
                //verificamos que la coalición sea con el tag Link donde esta nuestro prefap
				if (hit.collider.tag == "Link")
				{
                    //Destruir el Link en el que hacemos click 
					Destroy(hit.collider.gameObject);
                    //Destroy(hit.transform.parent.gameObject, 2f);
                }
            }
		}
	}
}
