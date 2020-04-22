namespace HREngine.Bots
{
    class Sim_CS2_082_H1 : SimTemplate //* 邪恶短刀 Wicked Knife
    {
        //
        //
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_082);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

    }
}