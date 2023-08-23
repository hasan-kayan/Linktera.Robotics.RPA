using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using LinkteraRobotics.V4Legacy.CopySheet.Activities.Design.Designers;
using LinkteraRobotics.V4Legacy.CopySheet.Activities.Design.Properties;

namespace LinkteraRobotics.V4Legacy.CopySheet.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");

            builder.AddCustomAttributes(typeof(CopySheet), categoryAttribute);
            builder.AddCustomAttributes(typeof(CopySheet), new DesignerAttribute(typeof(CopySheetDesigner)));
            builder.AddCustomAttributes(typeof(CopySheet), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
