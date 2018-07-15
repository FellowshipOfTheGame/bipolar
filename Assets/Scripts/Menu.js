#pragma strict
function Exit(){
	Application.Quit();

}

function Back(){
	Application.LoadLevel("Menu");
}

function SelectPhase(){
	Application.LoadLevel("Selection");
}

function Play(){
	Application.LoadLevel("Selection");
}

function Phase2(){
	Application.LoadLevel("Phase2");
}