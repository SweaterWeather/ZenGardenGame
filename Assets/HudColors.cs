using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// This controller script causes the sliders to actually do something and change the colors of the sprites accordingly.
/// </summary>
public class HudColors : MonoBehaviour
{

    /// <summary>
    /// The source head for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor headSeed1;

    /// <summary>
    /// The source head for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor headSeed2;

    /// <summary>
    /// The source head for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor headSeed3;

    /// <summary>
    /// The source head for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor headSeed4;

    /// <summary>
    /// The source head for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor headSeed5;

    /// <summary>
    /// The source head for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor headSeedBack1;

    /// <summary>
    /// The source head for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor headSeedBack2;

    /// <summary>
    /// The source head for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor headSeedBack3;

    /// <summary>
    /// The source head for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor headSeedBack4;

    /// <summary>
    /// The source head for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor headSeedBack5;

    /// <summary>
    /// The source body for reinstantiation every time the colors are altered.
    /// </summary>
    public SetColor bodySeed;

    /// <summary>
    /// This is the head of the sprite.
    /// </summary>
    public SetColor head;

    /// <summary>
    /// This is the head of the sprite.
    /// </summary>
    public SetColor headBack;

    /// <summary>
    /// This is the body of the sprite.
    /// </summary>
    public SetColor body;

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setRedHeadr(Slider hue)
    {
        ColorController.redChannelHead.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setRedHeadg(Slider hue)
    {
        ColorController.redChannelHead.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setRedHeadb(Slider hue)
    {
        ColorController.redChannelHead.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setGreenHeadr(Slider hue)
    {
        ColorController.greenChannelHead.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setGreenHeadg(Slider hue)
    {
        ColorController.greenChannelHead.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setGreenHeadb(Slider hue)
    {
        ColorController.greenChannelHead.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlueHeadr(Slider hue)
    {
        ColorController.blueChannelHead.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlueHeadg(Slider hue)
    {
        ColorController.blueChannelHead.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlueHeadb(Slider hue)
    {
        ColorController.blueChannelHead.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setCyanHeadr(Slider hue)
    {
        ColorController.cyanChannelHead.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setCyanHeadg(Slider hue)
    {
        ColorController.cyanChannelHead.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setCyanHeadb(Slider hue)
    {
        ColorController.cyanChannelHead.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setMagentaHeadr(Slider hue)
    {
        ColorController.magentaChannelHead.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setMagentaHeadg(Slider hue)
    {
        ColorController.magentaChannelHead.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setMagentaHeadb(Slider hue)
    {
        ColorController.magentaChannelHead.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setYellowHeadr(Slider hue)
    {
        ColorController.yellowChannelHead.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setYellowHeadg(Slider hue)
    {
        ColorController.yellowChannelHead.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setYellowHeadb(Slider hue)
    {
        ColorController.yellowChannelHead.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlackHeadr(Slider hue)
    {
        ColorController.blackChannelHead.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlackHeadg(Slider hue)
    {
        ColorController.blackChannelHead.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlackHeadb(Slider hue)
    {
        ColorController.blackChannelHead.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setWhiteHeadr(Slider hue)
    {
        ColorController.whiteChannelHead.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setWhiteHeadg(Slider hue)
    {
        ColorController.whiteChannelHead.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setWhiteHeadb(Slider hue)
    {
        ColorController.whiteChannelHead.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setRedBodyr(Slider hue)
    {
        ColorController.redChannelBody.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setRedBodyg(Slider hue)
    {
        ColorController.redChannelBody.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setRedBodyb(Slider hue)
    {
        ColorController.redChannelBody.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setGreenBodyr(Slider hue)
    {
        ColorController.greenChannelBody.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setGreenBodyg(Slider hue)
    {
        ColorController.greenChannelBody.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setGreenBodyb(Slider hue)
    {
        ColorController.greenChannelBody.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlueBodyr(Slider hue)
    {
        ColorController.blueChannelBody.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlueBodyg(Slider hue)
    {
        ColorController.blueChannelBody.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlueBodyb(Slider hue)
    {
        ColorController.blueChannelBody.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setCyanBodyr(Slider hue)
    {
        ColorController.cyanChannelBody.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setCyanBodyg(Slider hue)
    {
        ColorController.cyanChannelBody.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setCyanBodyb(Slider hue)
    {
        ColorController.cyanChannelBody.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setMagentaBodyr(Slider hue)
    {
        ColorController.magentaChannelBody.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setMagentaBodyg(Slider hue)
    {
        ColorController.magentaChannelBody.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setMagentaBodyb(Slider hue)
    {
        ColorController.magentaChannelBody.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setYellowBodyr(Slider hue)
    {
        ColorController.yellowChannelBody.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setYellowBodyg(Slider hue)
    {
        ColorController.yellowChannelBody.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setYellowBodyb(Slider hue)
    {
        ColorController.yellowChannelBody.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlackBodyr(Slider hue)
    {
        ColorController.blackChannelBody.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlackBodyg(Slider hue)
    {
        ColorController.blackChannelBody.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setBlackBodyb(Slider hue)
    {
        ColorController.blackChannelBody.z = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setWhiteBodyr(Slider hue)
    {
        ColorController.whiteChannelBody.x = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setWhiteBodyg(Slider hue)
    {
        ColorController.whiteChannelBody.y = hue.value;
    }

    /// <summary>
    /// This sets a color channel for the sprites to use.
    /// </summary>
    public void setWhiteBodyb(Slider hue)
    {
        ColorController.whiteChannelBody.z = hue.value;
    }

    /// <summary>
    /// This resets the hud sprites in the character builder every time a slider moves.
    /// </summary>
    public void Refresh () {
        Destroy(head.gameObject);
        Destroy(headBack.gameObject);
        Destroy(body.gameObject);
        switch (HeadAnimate.index)
        {
            case 0:
                headBack = Instantiate(headSeedBack1);
                head = Instantiate(headSeed1);
                break;
            case 1:
                headBack = Instantiate(headSeedBack2);
                head = Instantiate(headSeed2);
                break;
            case 2:
                headBack = Instantiate(headSeedBack3);
                head = Instantiate(headSeed3);
                break;
            case 3:
                headBack = Instantiate(headSeedBack4);
                head = Instantiate(headSeed4);
                break;
            case 4:
                headBack = Instantiate(headSeedBack5);
                head = Instantiate(headSeed5);
                break;

        }
        body = Instantiate(bodySeed);
	}

    /// <summary>
    /// This launches the actual game.
    /// </summary>
    public void LoadGame()
    {
        AudioPlayer.PlayClickSound();
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// This function controls the dropdown menu for the head.
    /// </summary>
    /// <param name="drop"></param>
    public void ChangeHead(Dropdown drop)
    {
        HeadAnimate.index = drop.value;
        Refresh();
    }

    /// <summary>
    /// This resets the save data.
    /// </summary>
    void Start()
    {
        SavePlant_Lloyd.delete();
    }
}
