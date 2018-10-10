using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb = null;
	private GameManager gm = null;

	// Use this for initialization
	void Start () {
		// Setter rb til å peke på Rigidbody2D-komponenten på player-objektet.
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		// Håndterer input for hver frame
		HandleInput();
	}

	// Håndterer input
	void HandleInput(){
		// Oppgave 1.4
	}

	// Skal endre veien player faller
	void GravShift(){
		// inverterer rb (Rigidbody2D-komponenetens) gravity scale
		
	}

}

