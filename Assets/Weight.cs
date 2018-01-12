using UnityEngine;

public class Weight : MonoBehaviour {

    //Creamos la conexión de elementos 
	public float distanceFromChainEnd = 0.6f;

	public void ConnectRopeEnd (Rigidbody2D endRB)
	{
        //Generamos la última conexión 
		HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        //Se desactiva la autoconfiguracion del Join para ponerlo manualmente en distanceFromChainEnd
        joint.autoConfigureConnectedAnchor = false;
        //Conectamos el ultimo elemento de nuestra cadena  
		joint.connectedBody = endRB;
		joint.anchor = Vector2.zero;
		joint.connectedAnchor = new Vector2(0f, -distanceFromChainEnd);
	}

}
