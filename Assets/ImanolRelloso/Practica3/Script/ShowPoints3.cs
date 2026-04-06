using TMPro;
using UnityEngine;

public class ShowPoints3 : MonoBehaviour
{
    private TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    public void updatePoints()
    {
        if (!BeatManager3.instance.final)
            text.text = BeatManager3.instance.points.ToString();
        else if (BeatManager3.instance.win)
            text.text = "Has ganado";
        else
            text.text = "Has perdido";
    }
}
