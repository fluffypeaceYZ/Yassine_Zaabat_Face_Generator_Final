using UnityEngine;
using System.Collections;

public class GeneratorScript : MonoBehaviour {
	public Transform spawnhats;
	public Transform spawnfaces;
	public Transform spawneyes;
	public Transform spawnmouths;
	public Transform spawnbackgrounds;
	public GameObject [] eyes;
	public GameObject [] hats;
	public GameObject [] faces;
	public GameObject [] backgrounds;
	public GameObject [] mouths;
	private GameObject[] InstantGO = new GameObject[5];
	private int [] RandomNum = new int[5];
	 


	// Use this for initialization
	void Start () {
		

		faces[0]=GameObject.FindGameObjectWithTag("face1");
		faces[1]=GameObject.FindGameObjectWithTag("face2");
		faces[2]=GameObject.FindGameObjectWithTag("face3");
		faces[3]=GameObject.FindGameObjectWithTag("face4");


		eyes[0]=GameObject.FindGameObjectWithTag("eyes1");
		eyes[1]=GameObject.FindGameObjectWithTag("eyes2");
		eyes[2]=GameObject.FindGameObjectWithTag("eyes3");
		eyes[3]=GameObject.FindGameObjectWithTag("eyes4");

		hats[0]=GameObject.FindGameObjectWithTag("hats1");
		hats[1]=GameObject.FindGameObjectWithTag("hats2");
		hats[2]=GameObject.FindGameObjectWithTag("hats3");
		hats[3]=GameObject.FindGameObjectWithTag("hats4");

		backgrounds[0]=GameObject.FindGameObjectWithTag("back1");
		backgrounds[1]=GameObject.FindGameObjectWithTag("back2");
		backgrounds[2]=GameObject.FindGameObjectWithTag("back3");
		backgrounds[3]=GameObject.FindGameObjectWithTag("back4");

		mouths[0]=GameObject.FindGameObjectWithTag("mouths1");
		mouths[1]=GameObject.FindGameObjectWithTag("mouths2");
		mouths[2]=GameObject.FindGameObjectWithTag("mouths3");
		mouths[3]=GameObject.FindGameObjectWithTag("mouths4");




	}

	// Update is called once per frame
	void Update () {



		if (Input.GetKeyDown ("space")){

			if (RandomNum[0]!=null)
			{
				Destroy(InstantGO[0]);
				Destroy(InstantGO[1]);	
				Destroy(InstantGO[2]);	
				Destroy(InstantGO[3]);	
				Destroy(InstantGO[4]);	
			}

			GetComponent<AudioSource>().Play();

			RandomNum [0] = Random.Range (0, faces.Length);
			RandomNum [1] = Random.Range (0, eyes.Length);
			RandomNum [2] = Random.Range (0, hats.Length);
			RandomNum [3] = Random.Range(0,backgrounds.Length);
			RandomNum [4] = Random.Range(0,mouths.Length);

			InstantGO[0] = (GameObject)Instantiate (faces[RandomNum[0]], spawnfaces.position, spawnfaces.rotation);
			InstantGO[1] = (GameObject)Instantiate (eyes[RandomNum[1]], spawneyes.position, spawneyes.rotation);
			InstantGO[2] = (GameObject)Instantiate (hats[RandomNum[2]], spawnhats.position, spawnhats.rotation);
			InstantGO[3] = (GameObject)Instantiate (backgrounds[RandomNum[3]], spawnbackgrounds.position, spawnbackgrounds.rotation);
			InstantGO[4] = (GameObject)Instantiate (mouths[RandomNum[4]], spawnmouths.position, spawnmouths.rotation);


			}
	
	}		
}


