namespace FiyiStackDeskApp.Generators.G1.Modules.CSharp
{
    public static partial class CSharp
    {
        public static string DTO(G1ConfigurationComponent GeneratorConfigurationComponent, Areas.FiyiStackDeskApp.TableBack.Entities.Table Table)
        {
            try
            {
                string Content =
                $@"using {GeneratorConfigurationComponent.ChosenProject.Name}.Areas.{Table.Area}.{Table.Name}Back.Entities;
{GeneratorConfigurationComponent.G1FieldChainer.ForeignUsings_DTO}

{Library.Security.WaterMark(Library.Security.EWaterMarkFor.CSharp)}

namespace {GeneratorConfigurationComponent.ChosenProject.Name}.Areas.{Table.Area}.{Table.Name}Back.DTOs
{{
    public record Paginated{Table.Name}DTO
    {{
        public List<{Table.Name}> List{Table.Name} {{ get; init; }} = [];
        public List<User> ListUserCreation {{ get; init; }} = [];
        public List<User> ListUserLastModification {{ get; init; }} = [];

        //FOREIGN LISTS (TABLES)
        {GeneratorConfigurationComponent.G1FieldChainer.ForeignLists_DTO}

        public long TotalRecordsInDatabase {{ get; set; }}
        public int TotalRecordsInTheList {{ get; set; }}
        public int PageIndex {{ get; set; }}
        public int PageSize {{ get; set; }}
        public int TotalPages => (int)Math.Ceiling(TotalRecordsInTheList / (double)PageSize);
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;
    }}
}}";

                return Content;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
