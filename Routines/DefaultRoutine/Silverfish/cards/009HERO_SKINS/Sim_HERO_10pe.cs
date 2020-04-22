using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_HERO_10pe  : SimTemplate// HERO_10pe  恶魔之爪
	  //在本回合中，你的英雄获得+1攻击力。
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