using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class PrepareScrollView : MonoBehaviour
{
    public List<BlockInven> allBlocks = new();
    public List<GameObject> listOfBlocks = new();
    public GameObject cellPrefab;

    private float gapX = 217.5f;
    private float gapY = 216.8f;
    private float blockGap = 920f;
    private int blockCount = 0;
    [SerializeField]private CellNode previousNode, currentNode;

    private string block1Color = "CF5B40";
    private string block2Color = "3B6D8C";
    private string block3Color = "3B7FB2";
    private string blockVideoColor = "55498F";
    private string blockRareColor = "EFE85D";
    private string blockLegendaryColor = "A561EF";
    private string blockMonstersColor = "DEBBEF";
    private string blockPiratesColor = "AFD0F9";
    private string blockJungleColor = "BEE771";
    private string blockTreasureColor = "E9C776";
    private string blockIceAgeColor = "79C8D7";
    private string blockKingdomsColor = "FE92BD";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //We should take state of Knives from Json when we go to main menu
        //And send that to a transfer script
        //So when we go to inventory, we have all state of all knives to use
        //Update: 
        //Can use tha t transfer to get state of Knives to use in this scene too

        //Use "ColorUtility.TryParseHtmlString(fullHex, out myColor)" to get Color from Hex
        //Hex = "#xxxxxx"

        foreach (var block in allBlocks)
        {
            for(int i = 0; i < block.knives.Count; i++)
            {
                Vector3 newPos = new Vector3(cellPrefab.transform.position.x + (i % 4) * gapX, cellPrefab.transform.position.y - (i / 4) * gapY, 0);
                GameObject cellClone = Instantiate(cellPrefab, listOfBlocks[blockCount].transform, false);
                cellClone.transform.localPosition = newPos;
                cellClone.SetActive(false);
                CellNode nodeScript = cellClone.GetComponent<CellNode>();

                if (block.knivesAndTheirState[block.knives[i]])//Unlocked State
                {
                    Transform unlockedGO = cellClone.transform.Find("Unlocked");
                    Transform lockedGO = cellClone.transform.Find("Locked");
                    unlockedGO.gameObject.SetActive(true);
                    lockedGO.gameObject.SetActive(false);

                    Transform knifeIcon = unlockedGO.Find("Knife");
                    Image knifeImage = knifeIcon.GetComponent<Image>();
                    knifeImage.sprite = block.knives[i];
                    nodeScript.cellState = CellState.Unlocked;
                }
                else//Locked State
                {
                    Transform unlockedGO = cellClone.transform.Find("Unlocked");
                    Transform lockedGO = cellClone.transform.Find("Locked");
                    unlockedGO.gameObject.SetActive(false);
                    lockedGO.gameObject.SetActive(true);

                    Transform knifeIcon = lockedGO.Find("Knife Shadow");
                    Image knifeImage = knifeIcon.GetComponent<Image>();
                    knifeImage.sprite = block.knivesShadow[i];
                    nodeScript.cellState = CellState.Locked;
                }
                nodeScript.onClick += ClickNode;

                cellClone.SetActive(true);
            }
            blockCount++;
        }
    }

    public void ClickNode(CellNode node)
    {
        if(currentNode == null)
        {
            currentNode = node;
            currentNode.ActiveFrame();
        }
        else
        {
            currentNode = node;
            if (previousNode != currentNode)
            {
                currentNode.ActiveFrame();
                previousNode.DeactiveFrame();
            }
        }
        previousNode = currentNode;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
