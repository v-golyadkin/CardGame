using System.Collections.Generic;
using UnityEngine;

public class AddStatusEffectEffect : Effect
{
    [SerializeField] private StatusEffectType statusEffectType;
    [SerializeField] private int stackCount;

    public override GameAction GetGameAction(List<CombatantView> targets, CombatantView caster)
    {
        return new AddStatusEffectGA(statusEffectType, stackCount, targets);
    }

    public override int GetValue() => stackCount;
}
