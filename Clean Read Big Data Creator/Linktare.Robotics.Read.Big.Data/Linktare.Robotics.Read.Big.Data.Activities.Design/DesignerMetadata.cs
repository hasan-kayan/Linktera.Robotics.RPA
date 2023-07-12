using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using Linktare.Robotics.Read.Big.Data.Activities.Design.Designers;
using Linktare.Robotics.Read.Big.Data.Activities.Design.Properties;

namespace Linktare.Robotics.Read.Big.Data.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");

            builder.AddCustomAttributes(typeof(ReadBigData), categoryAttribute);
            builder.AddCustomAttributes(typeof(ReadBigData), new DesignerAttribute(typeof(ReadBigDataDesigner)));
            builder.AddCustomAttributes(typeof(ReadBigData), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
