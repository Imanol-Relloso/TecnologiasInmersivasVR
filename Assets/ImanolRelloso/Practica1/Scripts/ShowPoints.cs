using TMPro;
using UnityEngine;

public class ShowPoints : MonoBehaviour
{
    private TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    public void updatePoints()
    {
        if (!BeatManager.instance.final)
            text.text = BeatManager.instance.points.ToString();
        else
            text.text = "Has ganado";
    }
}
