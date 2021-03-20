using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidButonMeteor : MonoBehaviour {

	public bool sag,sol;

	public void SolDown(){
	
		sol = true;
	}

	public void SolUp(){

		sol = false;
	}

	public void SagDown(){

		sag = true;
    }

    public void SagUp()
    {

        sag = false;
    }

}
