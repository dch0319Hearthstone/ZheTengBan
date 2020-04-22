namespace HREngine.Bots
{
    class Sim_CS2_034_H3 : SimTemplate //* 火焰冲击 Fireblast
    {
        //<b>Hero Power</b>Deal $1 damage.
        //<b>英雄技能</b>造成$1点伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(1) : p.getEnemyHeroPowerDamage(1);
            p.minionGetDamageOrHeal(target, dmg);
        }

    }
}