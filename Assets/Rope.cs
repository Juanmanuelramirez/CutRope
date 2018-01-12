using UnityEngine;

public class Rope : MonoBehaviour {

    //Necesitamos la referencia al Hook
	public Rigidbody2D hook;

    //Creamos el link prefab
	public GameObject linkPrefab;

    //Creamos un elemento para el peso 
	public Weight weigth;

    //El numero de links que necesitamos 
	public int links = 7;

	void Start () {
		GenerateRope();
	}

	void GenerateRope ()
	{
        //Para comenzar la referencia necesitamos un primer elemento en escena Hook
		Rigidbody2D previousRB = hook;

        //instanciamos el numero de links que vamos a pintar 
		for (int i = 0; i < links; i++)
		{
            //Instanciamos cada uno de los links a partir del padre 
			GameObject link = Instantiate(linkPrefab, transform);

            //Creamos los elementos que estaran enlazados a Hook
			HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
			joint.connectedBody = previousRB;

			if (i < links - 1)
			{
				previousRB = link.GetComponent<Rigidbody2D>();
			} else
			{
                //En el ultimo elemento creamos la conexión al peso
                //Mandamos el link al ultimo elemento creado 
				weigth.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
			}

			
		}
	}

}
