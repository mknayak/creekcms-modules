using CreekWorm.Kernel;
using CreekWorm.Kernel.Common;
using CreekWorm.Kernel.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace creekcms.basemodule.Initialize
{
    public class InitializeBaseModule
    {
        public void Process() {
            //Create Templates
            //Create Layouts
            //Create Items
            //Any other configuration data
            var textTemplate = TemplateManager.AddTemplate("Text Only", IDs.Types.BaseModule, Ids.TemplateBase, IDs.Types.OnlyText.Type);
            var fieldSectionDataSection = ItemManager.AddItem("Data", Ids.Editor.Type.System.Types.FieldSectionTemplate, IDs.Types.OnlyText.Type, CreekWorm.Kernel.Items.ItemType.Item | CreekWorm.Kernel.Items.ItemType.System, IDs.Types.OnlyText.DataSection);
            TemplateField nameField = TemplateField.New("Name", Ids.Editor.Type.System.Fields.TextField, IDs.Types.OnlyText.NameField);
            TemplateManager.AddTemplateField(nameField, fieldSectionDataSection.Id);

            var listTemplate = TemplateManager.AddTemplate("SimpleList", IDs.Types.BaseModule, Ids.TemplateBase, IDs.Types.OnlyText.Type);
            var dataSection = ItemManager.AddItem("Data", Ids.Editor.Type.System.Types.FieldSectionTemplate, IDs.Types.OnlyText.Type, CreekWorm.Kernel.Items.ItemType.Item | CreekWorm.Kernel.Items.ItemType.System, IDs.Types.OnlyText.DataSection);
            TemplateField titleField = TemplateField.New("Title", Ids.Editor.Type.System.Fields.TextField, IDs.Types.OnlyText.NameField);
            TemplateManager.AddTemplateField(nameField, dataSection.Id);

        }
    }

    public static class Keys
    {
        public const string BaseModule = "Base Module";
    }
    public static class IDs
    {
        public static class Web
        {
            public const string BaseModule = "";
            public const string BundleTypeNode = "";
            public const string JSType = "";
            public const string CSSType = "";
        }
        public static class View
        {
            public const string BaseModule = "";
            public const string JSBundle = "";
            public const string CSSBundle = "";
        }
        public static class Types
        {
            public const string BaseModule = "";
            public static class OnlyText
            {
                public const string Type = "";
                public const string DataSection = "";
                public const string NameField = "";
            }
            public static class SimpleList
            {
                public const string Type = "";
                public const string DataSection = "";
                public const string TitleField = "";
                public const string DescriptionField = "";
                public const string ItemListField = "";
            }
        }
    }
}