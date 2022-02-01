using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.DataStore.Document.Models;

namespace CluedIn.Provider.Northwind
{
    public class RelatedEntitiesHelper
    {
        private readonly ExecutionContext context;
        private readonly Entity entity;

        public RelatedEntitiesHelper(ExecutionContext _context, Entity _entity)
        {
            context = _context;
            entity = _entity;
        }

        public DataStore.Document.Models.SuggestedSearch GetRelationshipForEntity(string displayName, EntityEdgeType edgeType)
        {
            return new DataStore.Document.Models.SuggestedSearch
            {
                DisplayName = displayName,
                SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}}",
                Tokens = string.Format("{0},{1}", edgeType, entity.Id.ToString()),
                Type = "List"
            };
        }
        public DataStore.Document.Models.SuggestedSearch GetRelationshipForEntityOrderByField(string displayName, EntityEdgeType edgeType, string orderField)
        {
            return new DataStore.Document.Models.SuggestedSearch
            {
                DisplayName = displayName,
                SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}} order by {{FIELD}}",
                Tokens = string.Format("{0},{1},{2}", edgeType, entity.Id.ToString(), orderField),
                Type = "List"
            };
        }
        public DataStore.Document.Models.SuggestedSearch GetRelationshipForEntityOfMultipleTypes(string displayName, EntityEdgeType edgeType, params EntityType[] entityTypes)
        {
            return new DataStore.Document.Models.SuggestedSearch
            {
                DisplayName = displayName,
                SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}} of types {{TYPE}}",
                Tokens = string.Format("{0},{1},{2}", edgeType, entity.Id.ToString(), string.Join(",", entityTypes.ToString())),
                Type = "List"
            };
        }
        public DataStore.Document.Models.SuggestedSearch GetRelationshipForEntityOfType(string displayName, EntityEdgeType edgeType, EntityType entityType)
        {
            return new DataStore.Document.Models.SuggestedSearch
            {
                DisplayName = displayName,
                SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}} of type {{TYPE}}",
                Tokens = string.Format("{0},{1},{2}", edgeType, entity.Id.ToString(), entityType),
                Type = "List"
            };
        }
        public DataStore.Document.Models.SuggestedSearch GetRelationshipForEntityOfTypeOrderByField(string displayName, EntityEdgeType edgeType, EntityType entityType, string orderField)
        {
            return new DataStore.Document.Models.SuggestedSearch
            {
                DisplayName = displayName,
                SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}} of type {{TYPE}} order by {{FIELD}}",
                Tokens = string.Format("{0},{1},{2},{3}", edgeType, entity.Id.ToString(), entityType, orderField),
                Type = "List"
            };
        }
        public DataStore.Document.Models.SuggestedSearch GetRelationshipForEntityOfTypeToEntityOfType(string displayName, EntityEdgeType edgeType, EntityType entityFrom, EntityType entityTo)
        {
            return new DataStore.Document.Models.SuggestedSearch
            {
                DisplayName = displayName,
                SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}} of type {{TYPE}}->{{TYPE2}}",
                Tokens = string.Format("{0},{1},{2}", edgeType, entity.Id.ToString(), entityFrom, entityTo),
                Type = "List"
            };
        }
        public DataStore.Document.Models.SuggestedSearch GetRelationshipForEntityOfTypeFromEntityOfType(string displayName, EntityEdgeType edgeType, EntityType entityFrom, EntityType entityTo)
        {
            return new DataStore.Document.Models.SuggestedSearch
            {
                DisplayName = displayName,
                SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}} of type {{TYPE}}<-{{TYPE2}}",
                Tokens = string.Format("{0},{1},{2}", edgeType, entity.Id.ToString(), entityFrom, entityTo),
                Type = "List"
            };
        }
    }
}
