#pragma strict

var flame : GameObject;

function Start () {

flame.SetActive(false);

}

function OnTriggerEnter2D () { flame.SetActive (true); }

function OnTriggerExit2D () { flame.SetActive(false); }
