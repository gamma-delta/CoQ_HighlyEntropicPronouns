using HarmonyLib;
using XRL.World;

namespace at.petrak.HighlyEntropicPronouns {
  [HarmonyPatch(typeof(GameObject), nameof(GameObject.GetPronounProvider))]
  public class GameObjectGetPronounProviderPatch {
    static bool Prefix(ref GameObject __instance, ref IPronounProvider __result) {
      var self = __instance;

      if (!self.IsMemberOfFaction("highly entropic beings")) {
        return true; // don't clobber out
      }

      __result = HighlyEntropicPronounProvider.Instance;
      return false; // do clobber out
    }
  }
}
