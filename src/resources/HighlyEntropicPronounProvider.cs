using XRL.World;

namespace at.petrak.HighlyEntropicPronouns {
  public class HighlyEntropicPronounProvider : IPronounProvider {
    public static readonly IPronounProvider Instance = new HighlyEntropicPronounProvider();

    private static IPronounProvider Roll() {
      IPronounProvider ret = 5.in10()
        ? (IPronounProvider) Gender.All?.GetRandomElement()
        : (IPronounProvider) PronounSet.All?.GetRandomElement();
      return ret ?? PronounSet.GetAny();
    }

    public string Name => "highly entropic";
    public string CapitalizedName => "highly entropic";
    public bool Generic => false;
    public bool Generated => false;
    public bool Plural => Roll().Plural;
    public bool PseudoPlural => Roll().PseudoPlural;
    public string Subjective => Roll().Subjective;
    public string CapitalizedSubjective => Roll().CapitalizedSubjective;
    public string Objective => Roll().Objective;
    public string CapitalizedObjective => Roll().CapitalizedObjective;
    public string PossessiveAdjective => Roll().PossessiveAdjective;
    public string CapitalizedPossessiveAdjective => Roll().CapitalizedPossessiveAdjective;
    public string SubstantivePossessive => Roll().SubstantivePossessive;
    public string CapitalizedSubstantivePossessive => Roll().CapitalizedSubstantivePossessive;
    public string Reflexive => Roll().Reflexive;
    public string CapitalizedReflexive => Roll().CapitalizedReflexive;
    public string PersonTerm => Roll().PersonTerm;
    public string CapitalizedPersonTerm => Roll().CapitalizedPersonTerm;
    public string ImmaturePersonTerm => Roll().ImmaturePersonTerm;
    public string CapitalizedImmaturePersonTerm => Roll().CapitalizedImmaturePersonTerm;
    public string FormalAddressTerm => Roll().FormalAddressTerm;
    public string CapitalizedFormalAddressTerm => Roll().CapitalizedFormalAddressTerm;
    public string OffspringTerm => Roll().OffspringTerm;
    public string CapitalizedOffspringTerm => Roll().CapitalizedOffspringTerm;
    public string SiblingTerm => Roll().SiblingTerm;
    public string CapitalizedSiblingTerm => Roll().CapitalizedSiblingTerm;
    public string ParentTerm => Roll().ParentTerm;
    public string CapitalizedParentTerm => Roll().CapitalizedParentTerm;
    public string IndicativeProximal => Roll().IndicativeProximal;
    public string CapitalizedIndicativeProximal => Roll().CapitalizedIndicativeProximal;
    public string IndicativeDistal => Roll().IndicativeDistal;
    public string CapitalizedIndicativeDistal => Roll().CapitalizedIndicativeDistal;
    public bool UseBareIndicative => Roll().UseBareIndicative;
  
  }
}
