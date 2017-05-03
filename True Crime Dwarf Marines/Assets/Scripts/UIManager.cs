using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour {

	public Text objectText;
	public Image objectImage;
	public Objecto Hurkuhm;
	public Objecto Brynwynn;
	public Objecto Thorom;
	public Objecto Hjulthrun;
	public Objecto Darkon;
	public Objecto Byllin;
	public Objecto HammerOfDoom;
	public Objecto DogTags;
	public Objecto GlassEye;
	public Objecto Hurkguhn;
	public Objecto JamStain;
	public Objecto Lens;
	public Objecto NutsAndBolts;
	public Objecto Pillow;
	public Objecto Telescope;
	public Objecto TrailMix;
	public Objecto Poison;
	public Sprite HurkuhmS;
	public Sprite BrynwynnS;
	public Sprite ThoromS;
	public Sprite HjulthrunS;
	public Sprite DarkonS;
	public Sprite ByllinS;
	public Sprite HammerOfDoomS;
	public Sprite DogTagsS;
	public Sprite GlassEyeS;
	public Sprite HurkguhnS;
	public Sprite JamStainS;
	public Sprite LensS;
	public Sprite NutsAndBoltsS;
	public Sprite PillowS;
	public Sprite TelescopeS;
	public Sprite TrailMixS;
	public Sprite PoisonS;
	public Sprite RedwynnS;
	public Objecto RedwynnG;
	public Objecto BrynwynnG;
	public Objecto ThoromG;
	public Objecto HjulthrunG;
	public Objecto DarkonG;
	public Objecto ByllinG;

	// Use this for initialization
	void Start () {
		objectText.text = "AT APPROXIMATELY 0700 HOURS HURKUHM THE MECHANIC WAS FOUND DEAD IN THE BOILER ROOM.";

	}

	// Update is called once per frame
	void Update () {
		if (Hurkuhm.clicked==true) {
			objectImage.sprite = HurkuhmS;
			objectText.text = "Hurkuhm: ...";
		}
		if (Brynwynn.clicked==true) {
			objectImage.sprite = BrynwynnS;
			objectText.text = "Brynwynn: Where was I during the murder? Same place as always: lookout. Just doing my job. Some lookout I am now that Hurkuhm's gone and gotten himself killed under my watch while I was searchin' for that good for nothin' lens. Say, Red, didn't you say you had some business to take care of in the Boiler Room? Did you happen to see anyone else down there? Anyone suspiscious?";
		}
		if (Thorom.clicked==true) {
			objectImage.sprite = ThoromS;
			objectText.text = "Thorom: G'afternoon, Captain Renwynn! What kept ya this mornin'? YOu missed breakfast. Wha- Hurkuhm? Darn bastard stumbled in the other day, ruinin my kitchen and what not -- had to chase 'im outta there, that numbskull. Shoulda seen it comin' one of these days.";
		}
		if (Hjulthrun.clicked==true) {
			objectImage.sprite = HjulthrunS;
			objectText.text = "Hjulthrun: I was here the whole time; right here on this bunk. Haven't touched the floor since I sat down -- nope. Why'd I wanna hurt Hurkuhm. Sure, he never shuts up at night and keeps asking these ridiculous philosphical questions, but I'd never hurt the guy, let alone kill him. At least I'll finally be getting some real sleep now. But, some time last night, he just disappeared and I heard, like, this loud-ass 'pachoom' sound coming from down below. Not quite sure what it was...";
		}
		if (Byllin.clicked==true) {
			objectImage.sprite = ByllinS;
			objectText.text = "Byllin: Good day, Captain! You sleep weird last night? You're walking awfully funny. Want me to take a look at it? No? Okay, then, it's your decision. Poor dumb, lazy ol' Hurkster, I needed him to fix the medbay sink today too. By the way, Darkom lost his fake eye some time this morning and I promised I'd help him find it. Wonder who'd have the nerve to hide it...";
		}
		if (Darkon.clicked==true) {
			objectImage.sprite = DarkonS;
			objectText.text = "Darkon: BWAHAHAHA- Captain! Don't mind me; just polishin' my Mighty Hammer of Doom and Torment for another hardworkin' day. Yeah, you heard right, I lost my eye again. But I've got a theory that someone's stolen it! Because it's nowhere on this blasted ship! Y'see, my eye is equipt with a camera that records just 'bout everythin' on this boat, so if someone murdered Hurkuhm, they'd also take good ole eyevan for good measures.";
		}
		if (Poison.clicked==true) {
			objectImage.sprite = PoisonS;
			objectText.text = "Poison: A common culinary tool.";
		}
		if (HammerOfDoom.clicked==true) {
			objectImage.sprite = HammerOfDoomS;
			objectText.text = "The Hammer of Doom and Torment: It oozes with dark energy and you swear you can hear faint screams eminating from the stained hammerhead...wait, is this thing made of foam?";
		}
		if (GlassEye.clicked==true) {
			objectImage.sprite = GlassEyeS;
			objectText.text = "Glass Eye: It's been powered off.";
		}
		if (Telescope.clicked==true) {
			objectImage.sprite = TelescopeS;
			objectText.text = "Telescope: The lens has been removed and it looks a bit battered.";
		}
		if (Lens.clicked==true) {
			objectImage.sprite = LensS;
			objectText.text = "Lens: A clear glass lens.";
		}
		if (Pillow.clicked==true) {
			objectImage.sprite = PillowS;
			objectText.text = "Pillow: It's been freshly fluffed!";
		}
		if (Hurkguhn.clicked==true) {
			objectImage.sprite = HurkguhnS;
			objectText.text = "The Hurkguhn: Hurkuhm's signature weapon. It's still warm.";
		}

		if (NutsAndBolts.clicked==true) {
			objectImage.sprite = NutsAndBoltsS;
			objectText.text = "Nuts and Bolts: Screwdriver tips, nuts, and bolts are scattered across the ground. A lone peanut and some M&M's sit among the metal.";
		}

		if (TrailMix.clicked==true) {
			objectImage.sprite = TrailMixS;
			objectText.text = "Trailmix: The kind that is 70% peanut with the ocassional M&M.";
		}

		if (JamStain.clicked==true) {
			objectImage.sprite = JamStainS;
			objectText.text = "Jam Stain: This blood tastes suspiciously like strawberries.";
		}
		if (DogTags.clicked==true) {
			objectImage.sprite = DogTagsS;
			objectText.text = "Broken Dog Tags: These are Hurkhum's.";
		}
		if (RedwynnG.clicked==true) {
			objectText.text = "Redwynn: Though we're sad to see Hurkhum go, his death remains a mystery. So, we have a long trip back to port and plenty of work to do. There's no time for you to tread carefully. *You'd never see me coming anyways*";
		}
		if (BrynwynnG.clicked==true) {
			objectText.text = "Redwynn: Let it be known that Brynwynn murdered Hurkhum! Set a course for the Deep Cove, by the power vested in me I sentence you to death by marooning.";
		}
		if (ThoromG.clicked==true) {
			objectText.text = "Redwynn: Let it be known that Thorom murdered Hurkhum! Set a course for the Deep Cove, by the power vested in me I sentence you to death by marooning.";
		}
		if (HjulthrunG.clicked==true) {
			objectText.text = "Hjulthrun: Let it be known that Hjulthrun murdered Hurkhum! Set a course for the Deep Cove, by the power vested in me I sentence you to death by marooning.";
		}
		if (DarkonG.clicked==true) {
			objectText.text = "Darkon: Let it be known that Darkon murdered Hurkhum! Set a course for the Deep Cove, by the power vested in me I sentence you to death by marooning.";
		}
		if (ByllinG.clicked==true) {
			objectText.text = "Byllin: Let it be known that Byllin murdered Hurkhum! Set a course for the Deep Cove, by the power vested in me I sentence you to death by marooning.";
		}
	}

	public void Solve(){
		objectImage.sprite = RedwynnS;
		objectText.text = "Choose a suspect to convict.";
	}
}