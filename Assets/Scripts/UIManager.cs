using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI life;
    public TextMeshProUGUI damage;
    public TextMeshProUGUI speed;
    public TextMeshProUGUI Turn;
    void Start()
    {
        life.text = $"Life: {GameManager.instance.player.Life}";
        damage.text = $"Damage: {GameManager.instance.player.Damage}";
        speed.text = $"Speed: {GameManager.instance.player.Speed}";
        Turn.text = $"Turn: {GameManager.instance.snapshotSystem.Count}";

        GameManager.instance.NewTurn += () =>
        {
            life.text = $"Life: {GameManager.instance.player.Life}";
            damage.text = $"Damage: {GameManager.instance.player.Damage}";
            speed.text = $"Speed: {GameManager.instance.player.Speed}";
            Turn.text = $"Turn: {GameManager.instance.snapshotSystem.Count}";
        };
    }

    void Update()
    {
        
    }
    public void ChangeStats()
    {

    }
}
