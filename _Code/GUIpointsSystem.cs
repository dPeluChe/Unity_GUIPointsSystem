/*
################################################################
##                dPeluCheStudios.com                         ##
##                GUI Point System                            ##
##                By dPeluChe                                 ##
##                                                            ##
################################################################
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GUIpointsSystem : MonoBehaviour {
	
	//GUI ELEMENTS
	public Sprite[] _AllGuiNumbers;


	private GameObject[] _numObjs;
	private int _initTxtSize; 
	private string 	_txtMain;


	void Awake()
	{
		_txtMain = "21234123000";

		//createString ();

		createSpriteFromString ();

		_initTxtSize = _txtMain.Length;

		changeSprites();
		//changePointsValue (0);
	}
	
	private void createString(){
		_txtMain = "0";
	}

	private void createSpriteFromString()
	{
		_numObjs = new GameObject[_txtMain.Length];

		float objPosX = 0.0f;

		for (int i = 0; i < _txtMain.Length; i++) {
			int tmpValue =(int) char.GetNumericValue(_txtMain[i]);

			GameObject objTmp = new GameObject();
			objTmp.transform.parent = this.transform;
			objTmp.AddComponent<SpriteRenderer>();

			objTmp.GetComponent<SpriteRenderer>().sprite = _AllGuiNumbers[tmpValue];
			objPosX += _AllGuiNumbers[tmpValue].bounds.size.x;
			objTmp.name = "_Num_"+i+"_"+tmpValue;

			objPosX += 0.01f;
			objTmp.transform.position = new Vector3(this.transform.position.x +objPosX, this.transform.position.y,this.transform.position.z);
			_numObjs[i] = objTmp;
		}
	}

	public void setInCenterOfParent(){
		Vector3 parentPos = this.transform.GetChild (0).position;

		for (int i=0; i < this.transform.childCount; i++) {

			if (this.transform.childCount == 1)
				this.transform.GetChild (i).position = new Vector3 (parentPos.x-(0.27f), parentPos.y,parentPos.z-0.1f);
			else{
				float totalSpace  = this.transform.parent.renderer.bounds.size.x;
				this.transform.GetChild (i).position = new Vector3 (parentPos.x-(totalSpace/2)+(((totalSpace/2)-0.15f)*(i-1)), parentPos.y,parentPos.z-0.1f);
			}
		}
	}

	public void changePointsValue(int points){
		_txtMain = points.ToString();

		if(_txtMain.Length == _initTxtSize){
			changeSprites();
		}
	}
	
	private void changeSprites(){
		for (int i = 0; i < _numObjs.Length; i++) {
			int tmpValue = (int) char.GetNumericValue(_txtMain[i]);
			_numObjs[i].GetComponent<SpriteRenderer>().sprite = _AllGuiNumbers[tmpValue];	
		}
	}
	
	private void removeChilds(){
		for (int i=0; i < this.transform.childCount; i++) {
			Destroy(this.transform.GetChild(i).gameObject);
		}
	}
}