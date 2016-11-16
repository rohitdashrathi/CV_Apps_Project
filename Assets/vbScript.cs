using UnityEngine;
using System.Collections;
using Vuforia;
//[RequireComponent(typeof(AudioSource))]
public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject CButton;
	private GameObject DButton;
	private GameObject EButton;
	private GameObject FButton;
	private GameObject GButton;
	private GameObject AButton;
	private GameObject BButton;
	public AudioSource C3;
	public AudioSource D3;
	public AudioSource E3;
	public AudioSource F3;
	public AudioSource G3;
	public AudioSource A3;
	public AudioSource B3;

	// Use this for initialization
	void Start () {

		CButton = GameObject.Find ("CButton");  // Finds the Virtual Button Object
		DButton = GameObject.Find ("DButton");  // Finds the Virtual Button Object
	    EButton = GameObject.Find ("EButton");  // Finds the Virtual Button Object
	    FButton = GameObject.Find ("FButton");  // Finds the Virtual Button Object
	    GButton = GameObject.Find ("GButton");  // Finds the Virtual Button Object
	    AButton = GameObject.Find ("AButton");  // Finds the Virtual Button Object
	    BButton = GameObject.Find ("BButton");  // Finds the Virtual Button Object

		AudioSource C3 = gameObject.AddComponent<AudioSource>();
		AudioSource D3 = gameObject.AddComponent<AudioSource>();
		AudioSource E3 = gameObject.AddComponent<AudioSource>();
		AudioSource F3 = gameObject.AddComponent<AudioSource>();
		AudioSource G3 = gameObject.AddComponent<AudioSource>();
		AudioSource A3 = gameObject.AddComponent<AudioSource>();
		AudioSource B3 = gameObject.AddComponent<AudioSource>();
		//Audio_Source.clip = Resources.Load("C3") as AudioClip;

		//Audio_Source.Play();
	
		//CNote.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this); // 

		VirtualButtonBehaviour[] vbs = transform.GetComponentsInChildren<VirtualButtonBehaviour> ();

		for (int i=0; i < vbs.Length; ++i) {
			vbs[i].RegisterEventHandler(this);
		}



	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
	{
		if(vb.name=="CButton") 
		{ Debug.Log ("C Note Pressed!!!");
			//AudioSource Audio_Source = gameObject.AddComponent<AudioSource>();
			//Audio_Source.clip = Resources.Load("C3") as AudioClip;
			C3.Play();
			//Audio_Source.Play();
		}

		if(vb.name=="DButton") 
		{ Debug.Log ("D Note Pressed!!!");
			D3.Play();
		}

		if(vb.name=="EButton") 
		{ Debug.Log ("E Note Pressed!!!");
			E3.Play();}

		if(vb.name=="FButton") 
		{ Debug.Log ("F Note Pressed!!!");
			F3.Play();}

		if(vb.name=="GButton") 
		{ Debug.Log ("G Note Pressed!!!");
			G3.Play();}

		if(vb.name=="AButton") 
		{ Debug.Log ("A Note Pressed!!!");
			A3.Play();}

		if(vb.name=="BButton") 
		{ Debug.Log ("B Note Pressed!!!");
			B3.Play();}

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
	{
		//Debug.Log ("C Note released");
	}


}
