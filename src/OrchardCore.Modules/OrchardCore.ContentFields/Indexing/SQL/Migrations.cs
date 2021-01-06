using System;
using OrchardCore.ContentManagement.Records;
using OrchardCore.Data.Migration;
using YesSql.Sql;

namespace OrchardCore.ContentFields.Indexing.SQL
{
    public class Migrations : DataMigration
    {
        public int Create()
        {
            // NOTE: The Text Length has been decreased from 4000 characters to 768.
            // For existing SQL databases update the TextFieldIndex tables Text column length manually.
            SchemaBuilder.CreateMapIndexTable<TextFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<string>("Text", column => column.Nullable().WithLength(TextFieldIndex.MaxTextSize))
                .Column<string>("BigText", column => column.Nullable().Unlimited())
            );

            SchemaBuilder.AlterIndexTable<TextFieldIndex>(table => table
                .CreateIndex("IDX_TextFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Text")
            );

            SchemaBuilder.CreateMapIndexTable<BooleanFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<bool>("Boolean", column => column.Nullable())
            );

            SchemaBuilder.AlterIndexTable<BooleanFieldIndex>(table => table
                .CreateIndex("IDX_BooleanFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Boolean")
            );

            SchemaBuilder.CreateMapIndexTable<NumericFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<decimal>("Numeric", column => column.Nullable())
            );

            SchemaBuilder.AlterIndexTable<NumericFieldIndex>(table => table
                .CreateIndex("IDX_NumericFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Numeric")
            );

            SchemaBuilder.CreateMapIndexTable<DateTimeFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<DateTime>("DateTime", column => column.Nullable())
            );

            SchemaBuilder.AlterIndexTable<DateTimeFieldIndex>(table => table
                .CreateIndex("IDX_DateTimeFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "DateTime")
            );

            SchemaBuilder.CreateMapIndexTable<DateFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<DateTime>("Date", column => column.Nullable())
            );

            SchemaBuilder.AlterIndexTable<DateFieldIndex>(table => table
                .CreateIndex("IDX_DateFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Date")
            );

            SchemaBuilder.CreateMapIndexTable<ContentPickerFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<string>("SelectedContentItemId", column => column.WithLength(26))
            );

            SchemaBuilder.AlterIndexTable<ContentPickerFieldIndex>(table => table
                .CreateIndex("IDX_ContentPickerFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "SelectedContentItemId")
            );

            SchemaBuilder.CreateMapIndexTable<TimeFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<DateTime>("Time", column => column.Nullable())
            );

            SchemaBuilder.AlterIndexTable<TimeFieldIndex>(table => table
                .CreateIndex("IDX_TimeFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Time")
            );

            // NOTE: The Url and Text Length has been decreased from 4000 characters to 768.
            // For existing SQL databases update the LinkFieldIndex tables Url and Text column length manually.
            // The BigText and BigUrl columns are new additions so will not be populated until the content item is republished.
            SchemaBuilder.CreateMapIndexTable<LinkFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<string>("Url", column => column.Nullable().WithLength(LinkFieldIndex.MaxUrlSize))
                .Column<string>("BigUrl", column => column.Nullable().Unlimited())
                .Column<string>("Text", column => column.Nullable().WithLength(LinkFieldIndex.MaxTextSize))
                .Column<string>("BigText", column => column.Nullable().Unlimited())
            );

            SchemaBuilder.AlterIndexTable<LinkFieldIndex>(table => table
                .CreateIndex("IDX_LinkFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Url",
                    "Text")
            );

            SchemaBuilder.CreateMapIndexTable<HtmlFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<string>("Html", column => column.Nullable().Unlimited())
            );

            SchemaBuilder.AlterIndexTable<HtmlFieldIndex>(table => table
                .CreateIndex("IDX_HtmlFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Html")
            );

            SchemaBuilder.CreateMapIndexTable<MultiTextFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<string>("Value", column => column.Nullable().WithLength(MultiTextFieldIndex.MaxValueSize))
                .Column<string>("BigValue", column => column.Nullable().Unlimited())
            );

            SchemaBuilder.AlterIndexTable<MultiTextFieldIndex>(table => table
                .CreateIndex("IDX_MultiTextFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Value")
            );

            // Shortcut other migration steps on new content definition schemas.
            return 4;
        }

        // This code can be removed in a later version.
        public int UpdateFrom1()
        {
            SchemaBuilder.AlterIndexTable<LinkFieldIndex>(table => table
                .AddColumn<string>("BigUrl", column => column.Nullable().Unlimited()));

            SchemaBuilder.AlterIndexTable<LinkFieldIndex>(table => table
                .AddColumn<string>("BigText", column => column.Nullable().Unlimited()));

            return 2;
        }

        // This code can be removed in a later version.
        public int UpdateFrom2()
        {
            SchemaBuilder.CreateMapIndexTable<MultiTextFieldIndex>(table => table
                .Column<string>("ContentItemId", column => column.WithLength(26))
                .Column<string>("ContentItemVersionId", column => column.WithLength(26))
                .Column<string>("ContentType", column => column.WithLength(ContentItemIndex.MaxContentTypeSize))
                .Column<string>("ContentPart", column => column.WithLength(ContentItemIndex.MaxContentPartSize))
                .Column<string>("ContentField", column => column.WithLength(ContentItemIndex.MaxContentFieldSize))
                .Column<bool>("Published", column => column.Nullable())
                .Column<bool>("Latest", column => column.Nullable())
                .Column<string>("Value", column => column.Nullable().WithLength(MultiTextFieldIndex.MaxValueSize))
                .Column<string>("BigValue", column => column.Nullable().Unlimited())
            );

            return 3;
        }

        // This code can be removed in a later version.
        public int UpdateFrom3()
        {
            SchemaBuilder.AlterIndexTable<TextFieldIndex>(table => table
                .CreateIndex("IDX_TextFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Text")
            );

            SchemaBuilder.AlterIndexTable<BooleanFieldIndex>(table => table
                .CreateIndex("IDX_BooleanFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Boolean")
            );

            SchemaBuilder.AlterIndexTable<NumericFieldIndex>(table => table
                .CreateIndex("IDX_NumericFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Numeric")
            );

            SchemaBuilder.AlterIndexTable<DateTimeFieldIndex>(table => table
                .CreateIndex("IDX_DateTimeFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "DateTime")
            );

            SchemaBuilder.AlterIndexTable<DateFieldIndex>(table => table
                .CreateIndex("IDX_DateFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Date")
            );

            SchemaBuilder.AlterIndexTable<ContentPickerFieldIndex>(table => table
                .CreateIndex("IDX_ContentPickerFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "SelectedContentItemId")
            );

            SchemaBuilder.AlterIndexTable<TimeFieldIndex>(table => table
                .CreateIndex("IDX_TimeFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Time")
            );

            SchemaBuilder.AlterIndexTable<LinkFieldIndex>(table => table
                .CreateIndex("IDX_LinkFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Url",
                    "Text")
            );

            SchemaBuilder.AlterIndexTable<HtmlFieldIndex>(table => table
                .CreateIndex("IDX_HtmlFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Html")
            );

            SchemaBuilder.AlterIndexTable<MultiTextFieldIndex>(table => table
                .CreateIndex("IDX_MultiTextFieldIndex_DocumentId",
                    "DocumentId",
                    "ContentItemId",
                    "ContentItemVersionId",
                    "ContentType",
                    "ContentPart",
                    "ContentField",
                    "Published",
                    "Latest",
                    "Value")
            );

            return 4;
        }
    }
}
