using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class OrderDetailsClueProducer : BaseClueProducer<OrderDetails>
    {
        private readonly IClueFactory factory;

        public OrderDetailsClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(OrderDetails input, Guid accountId)
        {
            var orderdetailsVocabulary = new OrderDetailsVocabulary();
            var clue = factory.Create(orderdetailsVocabulary.Grouping, input.OrderId.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.OrderId != null)
            {
                data.Name = input.OrderId;
                data.DisplayName = input.OrderId;
                data.Description = input.OrderId;
            }



            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }


            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[orderdetailsVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[orderdetailsVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
            // }


            //TODO: Example of PersonReference
            //  if (input.UpdatedBy != null)
            // {
            //     if (input.UpdatedByName != null)
            //     {
            //         var updatedPersonReference = new PersonReference(input.UpdatedByName, new EntityCode(EntityType.Person, NorthwindConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            //     else
            //     {
            //         var updatedPersonReference = new PersonReference(new EntityCode(EntityType.Person, NorthwindConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            // }

            //TODO: Mapping data into general properties metadata bag.
            //TODO: You should make sure as much data is mapped into specific metadata fields, rather than general .properties. bag.
            data.Properties[orderdetailsVocabulary.OrderId] = input.OrderId.PrintIfAvailable();
            data.Properties[orderdetailsVocabulary.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[orderdetailsVocabulary.UnitPrice] = input.UnitPrice.PrintIfAvailable();
            data.Properties[orderdetailsVocabulary.Quantity] = input.Quantity.PrintIfAvailable();
            data.Properties[orderdetailsVocabulary.Discount] = input.Discount.PrintIfAvailable();

            return clue;
        }
    }
}
