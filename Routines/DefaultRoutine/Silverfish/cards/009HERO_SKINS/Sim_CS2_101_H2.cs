namespace HREngine.Bots
{
    class Sim_CS2_101_H2 : SimTemplate //* 援军 Reinforce
    {
        //<b>Hero Power</b>Summon a 1/1 Silver Hand Recruit.
        //<b>英雄技能</b>召唤一个1/1的白银之手新兵。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);//silverhandrecruit

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
        }

    }
}