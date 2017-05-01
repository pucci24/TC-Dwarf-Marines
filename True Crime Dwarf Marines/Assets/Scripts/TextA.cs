using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextA : MonoBehaviour {

	public Text objectText;

	// Use this for initialization
	void Start () {
		objectText.text = "AT APPROXIMATELY 0700 HOURS THE HURKUHM THE MECHANIC WAS FOUND DEAD IN THE BOILER ROOM.";

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			objectText.text = "Where was I during the murder? Same place as always: lookout. Just doing my job. Some lookout I am now that Hurkuhm's gone and gotten himself killed under my watch while I was searchin' for that good for nothin' lens. Say, Red, didn't you say you had some business to take care of in the Boiler Room? Did you happen to see anyone else down there? Anyone suspiscious?";
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			objectText.text = "G'afternoon, Captain Renwynn! What kept ya this mornin'? YOu missed breakfast. Wha- Hurkuhm? Darn bastard stumbled in here the other day, ruinin my kitchen and what not -- had to chase 'im outta there, that numbskull. Shoulda seen it comin' one of these days.";
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			objectText.text = "I was here the whole time; right here on this bunk. Haven't touched the floor since I sat down -- nope. Why'd I wanna hurt Hurkuhm. Sure, he never shuts up at night and keeps asking these ridiculous philosphical questions, but I'd never hurt the guy, let alone kill him. At least I'll finally be getting some real sleep now. But, some time last night, he just disappeared and I heard, like, this loud-ass 'pachoom' sound coming from down below. Not quite sure what it was...";
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			objectText.text = "Good day, Captain! You sleeo weird last night? You're walking awfully funny. Want me to take a look at it? No? Okay, then, it's your decision. Hey, have you seen Hurk around? He's supposed to fix the sink in the medbay, but I can't for the life of me find him. That Hurkstehr, always finding new ways to slack off. Lazy pile 'o nothing good, he is. Tell me if you see him, alright sweetie? Okay, I gotta go. Darkom lost his fake eye some time this morning and I promised I'd help him find it. Wonder who'd have the nerve to hide it...";
		}
		if (Input.GetKeyDown (KeyCode.G)) {
			objectText.text = "BWAHAHAHA- Captain! Don't mind me; just polishin' my Mighty Hammer of Doom and Torment for another hardworkin' day. Yeah, you heard right, I lost my eye again. But I've got a theory that someone's stolen it! Because it's nowhere on this blasted ship! Y'see, my eye is equipt with a camera that records just 'bout everythin' on this boat, so if someone murdered Hurkuhm, they'd also take good ole eyevan for good measures.";
		}
		if (Input.GetKeyDown (KeyCode.Q)) {
			objectText.text = "Poison: A Common Culinary Tool.";
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			objectText.text = "The Hammer of Doom and Torment: It ooses with Dark Energy and you swear you can hear faint screams eminating from the stained hammerhead...wait, is this thing made of foam?";
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			objectText.text = "Telecope: The Lens has been Removed and it looks a bit Battered.";
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			objectText.text = "Lens: A Clear Glass Lens.";
		}
		if (Input.GetKeyDown (KeyCode.T)) {
			objectText.text = "Pillow: It's been Freshly Fluffed! There is a Saliva Stain in the Center.";
		}
		if (Input.GetKeyDown (KeyCode.Y)) {
			objectText.text = "The Hurkguhn: Hurkuhm's Signiture Weapon. It's still Warm.";
		}

		if (Input.GetKeyDown (KeyCode.U)) {
			objectText.text = "Nuts and Bolts: Screwdriver Tips, Nuts, and Bolts are Scattered Across the Ground. A Lone Peanut Sits Among the Metal.";
		}

		if (Input.GetKeyDown (KeyCode.I)) {
			objectText.text = "Trailmix: The Kind that is 70% Peanut with the Ocassional M&M.";
		}
	}
}