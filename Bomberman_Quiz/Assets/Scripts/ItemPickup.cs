using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public enum ItemType
    {
       // ExtraBomb,
        //BlastRadius,
       // SpeedIncrease,
        A,
        B,
        C,
    }

    public ItemType type;

    private void OnItemPickup(GameObject player)
{
    switch (type)
    {
        /*case ItemType.ExtraBomb:
            player.GetComponent<BombControllerUI>().AddBomb();
            break;

        case ItemType.BlastRadius:
            player.GetComponent<BombControllerUI>().explosionRadius++;
            break;

        case ItemType.SpeedIncrease:
            player.GetComponent<JoystickAnimateV2>().speed++;
            break;*/
        case ItemType.A:
            player.GetComponent<BombControllerUI>().callDecreaseBombrange();
            break;
        case ItemType.B:
            player.GetComponent<BombControllerUI>().callDecreaseBomb();
            break;
        case ItemType.C:
            player.GetComponent<JoystickAnimateV2>().A();
            break;
    }

    Destroy(gameObject);
}


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            OnItemPickup(other.gameObject);
        }
        else{
            OnItemPickup(other.gameObject);
        }
    }
}
