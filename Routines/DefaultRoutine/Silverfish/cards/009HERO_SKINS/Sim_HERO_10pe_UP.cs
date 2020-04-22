using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_HERO_10pe_UP  : SimTemplate// HERO_10pe_UP  恶魔之咬
	  //在本回合中，你的英雄获得+2攻击力。
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.minionGetTempBuff(p.ownHero, 2, 0);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 2, 0);
            }
        }
    }
}