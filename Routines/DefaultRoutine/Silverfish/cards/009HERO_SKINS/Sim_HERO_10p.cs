using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_HERO_10p : SimTemplate// HERO_10p  恶魔之爪
                                    //英雄技能
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.minionGetTempBuff(p.ownHero, 1, 0);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 1, 0);
            }
        }
    }
}