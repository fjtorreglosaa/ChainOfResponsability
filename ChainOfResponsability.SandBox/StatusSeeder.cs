using ChainOfResponsability.Domain.Models;
using ChainOfResponsability.Infrastructure.Contexts.Application;

namespace ChainOfResponsability.SandBox
{
    public class StatusSeeder
    {
        public static void Seed()
        {
            var context = new ApplicationDBContext();
            var dbStatuses = context.Statuses.ToList();
            var statusIds = dbStatuses.Select(x => x.Id).ToList();

            var statuses = new List<Status>
            {
                new Status
                {
                    Id = new Guid("BC985511-4E62-4309-8349-F90B942CF9C4"),
                    Name = "SUBMITTED",
                    Description = "Customer submits an order",
                    Type = "ORDER",
                    Order = 1,
                    Chain = "OrderProcessing"
                },
                new Status
                {
                    Id = new Guid("A5494443-EF2F-44CD-ADF8-C8E5C46C3D38"),
                    Name = "RECEIVED",
                    Description = "The company has received the order from the customer",
                    Type = "ORDER",
                    Order = 2,
                    Chain = "OrderProcessing"
                },
                new Status
                {
                    Id = new Guid("B5829769-24F2-42D8-9F5B-45B107C2FC71"),
                    Name = "IN PREPARATION",
                    Description = "The company is preparing the products for shipment",
                    Type = "ORDER",
                    Order = 3,
                    Chain = "OrderProcessing"
                },
                new Status
                {
                    Id = new Guid("04576888-6792-406A-AA6F-64012CC6B117"),
                    Name = "PREPARED",
                    Description = "The order has been completed and is waiting for the delivery service",
                    Type = "ORDER",
                    Order = 4,
                    Chain = "OrderProcessing"
                },
                new Status
                {
                    Id = new Guid("FC5C75E2-3242-4345-8A14-088CCB107313"),
                    Name = "ON ASSIGNMENT",
                    Description = "The system is selecting the delivery person",
                    Type = "ORDER",
                    Order = 5,
                    Chain = "OrderProcessing"
                },
                new Status
                {
                    Id = new Guid("1D7BD153-7954-41E1-83E9-C44DEF4F4BE2"),
                    Name = "ASSIGNED",
                    Description = "The system has selected the delivery person who will deliver the order to the customer",
                    Type = "ORDER",
                    Order = 6,
                    Chain = "OrderProcessing"
                },
                new Status
                {
                    Id = new Guid("2CC736F9-1A90-45C6-AF4D-9C3335B4015A"),
                    Name = "COLLECTED",
                    Description = "The selected delivery person has picked up the order",
                    Type = "ORDER",
                    Order = 7,
                    Chain = "OrderProcessing"
                },
                new Status
                {
                    Id = new Guid("EDD4233B-30CC-4FEA-9D8E-91E06F259877"),
                    Name = "ON ROUTE",
                    Description = "The delivery person is on his way to deliver the order",
                    Type = "ORDER",
                    Order = 8,
                    Chain = "OrderProcessing"
                },
                new Status
                {
                    Id = new Guid("8825C4CC-8415-46FC-807C-87D41979D25A"),
                    Name = "DELIVERED",
                    Description = "The delivery person has delivered the order to the customer",
                    Type = "ORDER",
                    Order = 9,
                    Chain = "OrderProcessing"
                },
                new Status
                {
                    Id = new Guid("212A14FF-D435-4674-A35D-53F3594CB98B"),
                    Name = "ACCEPTED",
                    Description = "The customer has accepted the order",
                    Type = "ORDER",
                    Order = 10,
                    Chain = "OrderProcessing"
                },
                new Status
                {
                    Id = new Guid("6AFB1DEE-FED7-41E0-9C25-42255862901C"),
                    Name = "CANCELLED",
                    Description = "The orders has been cancelled",
                    Type = "ORDER"
                },
                new Status
                {
                    Id = new Guid("99210CED-C9EC-44E4-A86F-2DD0EF23C8B4"),
                    Name = "CANCELLED",
                    Description = "The orders has been cancelled",
                    Type = "ORDER"
                },
                new Status
                {
                    Id = new Guid("B2C5BBF1-0B82-476E-B8B1-084BCDB2B24D"),
                    Name = "INVOICED",
                    Description = "The company has invoiced the customer",
                    Type = "INVOICE"
                },
                new Status
                {
                    Id = new Guid("C5BCF52D-2287-41A0-B93E-212DDA3D900E"),
                    Name = "PORTFOLIO IMPAIRMENT",
                    Description = "Portfolio impairment because the invoice deadline has expired",
                    Type = "INVOICE"
                },
                new Status
                {
                    Id = new Guid("C82D2B58-C2C4-423B-AC92-39CF56EF9A92"),
                    Name = "OVERDUE",
                    Description = "The deadline for collection of the invoice has expired",
                    Type = "INVOICE"
                },
                new Status
                {
                    Id = new Guid("5F3BA363-90CC-432C-9792-AE385AF7945B"),
                    Name = "PAID",
                    Description = "The customer has paid the invoice",
                    Type = "INVOICE"
                }
            };

            var Ids = statuses.Select(x => x.Id).ToList();

            if (!dbStatuses.Select(x => x.Id).Intersect(Ids).Any())
            {
                context.Statuses.AddRange(statuses);
                context.SaveChanges();
            }
        }
    }
}
