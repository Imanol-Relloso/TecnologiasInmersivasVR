using TMPro;
using UnityEngine;

public class ShowPoints2 : MonoBehaviour
{
    private TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    public void updatePoints()
    {
        if (!BeatManager2.instance.final)
            text.text = BeatManager2.instance.points.ToString();
        else
            text.text = "Has ganado";
    }
}
