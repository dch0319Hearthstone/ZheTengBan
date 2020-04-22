namespace HREngine.Bots
{
    class Sim_AT_132_HUNTER_H1 : SimTemplate //* 弩炮射击 Ballista Shot
    {
        //<b>Hero Power</b>Deal $3 damage.
        //<b>英雄技能</b>造成$3点伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(3) : p.getEnemyHeroPowerDamage(3);
            if (target == null) target = ownplay ? p.enemyHero : p.ownHero;
            p.minionGetDamageOrHeal(target, dmg);
        }

    }
}