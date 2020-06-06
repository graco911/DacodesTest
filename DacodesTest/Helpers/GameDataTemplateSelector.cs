using DacodesTest.Models.Games;
using Xamarin.Forms;

namespace DacodesTest.Helpers
{
    public class GameDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate VisitanteTemplate { get; set; }
        public DataTemplate LocalTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((GameData)item).Local ? LocalTemplate : VisitanteTemplate; 
        }
    }
}
