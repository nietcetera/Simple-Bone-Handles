using Vintagestory.API.Common;

namespace SimpleBoneHandles.Util
{
  class LoadConfig : ModSystem
  {
    public override void StartPre(ICoreAPI api)
    {
      base.StartPre(api);

      api.World.Logger.Event("Simple Bone Handles Loaded!");
    }
  }
}
