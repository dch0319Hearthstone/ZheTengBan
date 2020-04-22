namespace HREngine.Bots
{
    class Sim_CS2_049_H1_AT_132 : SimTemplate //* 图腾崇拜 Totemic Slam
    {
        //<b>Hero Power</b>Summon a Totem of your choice.
        //<b>英雄技能</b>召唤一个你想要的图腾。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_051);//Stoneclaw Totem

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, place, ownplay, false);
        }

    }
}