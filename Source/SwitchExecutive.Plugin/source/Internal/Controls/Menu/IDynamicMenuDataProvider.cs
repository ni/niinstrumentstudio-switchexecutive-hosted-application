using System.Collections.Generic;

namespace SwitchExecutive.Plugin.Internal.Controls.Menu
{
   public interface IDynamicMenuDataProvider
   {
      /// <summary>
      /// As a menu data provider, this method will get called by the MenuProvider to allow
      /// you to add IMenuItems. Your class is registered with the MenuProvider by calling its
      /// AddMenuDataProvider method. The owner of the MenuProvider defines what commandParameter
      /// will be passed to this method and you can optionally use when you create MenuItems.
      /// </summary>
      /// <param name="commandParameter">
      /// Specified by the owner of the MenuProvider and you can optionally use to create your MenuItems.
      /// </param>
      /// <returns></returns>
      IEnumerable<IMenuItem> CollectDynamicMenuItems(object commandParameter);
   }
}
