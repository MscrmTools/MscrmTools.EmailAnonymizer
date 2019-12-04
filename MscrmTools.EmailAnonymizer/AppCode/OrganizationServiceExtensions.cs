using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using System.Collections.Generic;
using System.Linq;

namespace MscrmTools.EmailAnonymizer.AppCode
{
    public static class OrganizationServiceExtensions
    {
        public static IEnumerable<EntityMetadata> GetEmailEnabledEntities(this IOrganizationService service)
        {
            EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
            {
                // Sans propriétés d'entité
                Properties = new MetadataPropertiesExpression
                {
                    AllProperties = false,
                    PropertyNames = { "DisplayName", "LogicalName", "Attributes", "PrimaryNameAttribute" }
                },
                AttributeQuery = new AttributeQueryExpression
                {
                    // Récupération de l'attribut spécifié
                    Criteria = new MetadataFilterExpression
                    {
                        Conditions =
                        {
                            new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.String)
                        }
                    },
                    // Avec uniquement les données d'OptionSet
                    Properties = new MetadataPropertiesExpression
                    {
                        AllProperties = false,
                        PropertyNames = { "EntityLogicalName", "DisplayName", "LogicalName", "Format" }
                    }
                },
            };

            RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
            {
                Query = entityQueryExpression,
                ClientVersionStamp = null
            };

            var response = (RetrieveMetadataChangesResponse)service.Execute(retrieveMetadataChangesRequest);

            return response.EntityMetadata.Where(e => e.Attributes.Any(a => a is StringAttributeMetadata amd && amd.Format == StringFormat.Email));
        }
    }
}