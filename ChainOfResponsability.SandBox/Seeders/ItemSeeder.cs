using ChainOfResponsability.Domain.Models;
using ChainOfResponsability.Infrastructure.Contexts.Application;

namespace ChainOfResponsability.SandBox.Seeders
{
    public class ItemSeeder
    {
        public static Item CHAIN = new Item
        {
            Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
            Name = "Chain",
            Price = (decimal)1.52,
        };
        public static Item ADHESIVES = new Item
        {
            Id = Guid.Parse("869FE37A-ADA5-46AD-B95D-70E09787B420"),
            Name = "Adhesives",
            Price = (decimal)0.25,
        };
        public static Item WRENCH = new Item
        {
            Id = Guid.Parse("8F351BD4-D8CA-4E39-82B2-2E0318A0587B"),
            Name = "Wrench",
            Price = (decimal)7.95,
        };
        public static Item TAP = new Item
        {
            Id = Guid.Parse("540E1B0C-FA93-4332-BE51-EDB32D4B6ECC"),
            Name = "Tap",
            Price = (decimal)0.58,
        };
        public static Item BELT = new Item
        {
            Id = Guid.Parse("FEFD75DC-750B-4753-956D-1D4CBFFB4CE8"),
            Name = "Belt",
            Price = (decimal)0.75,
        };
        public static Item BATTERIES = new Item
        {
            Id = Guid.Parse("C187C4F2-91E5-4B0E-A39F-EAACE686B82D"),
            Name = "Batteries",
            Price = (decimal)1.81,
        };
        public static Item HAMMER = new Item
        {
            Id = Guid.Parse("86C42729-0601-4790-90D1-5B1F4B9723DE"),
            Name = "Hammer",
            Price = (decimal)4.85,
        };
        public static Item AXE = new Item
        {
            Id = Guid.Parse("AB73086E-23D2-4169-9277-E02C31C5071D"),
            Name = "Axe",
            Price = (decimal)11.95,
        };
        public static Item PIPE = new Item
        {
            Id = Guid.Parse("4BAD732C-A893-479F-B94E-8EE2E92C75AC"),
            Name = "Pipe",
            Price = (decimal)6.55,
        };
        public static Item CEMENT = new Item
        {
            Id = Guid.Parse("E3487B57-A6FA-4025-8089-2E517F2966CF"),
            Name = "Cement",
            Price = (decimal)25.35,
        };
        public static Item PLASTER = new Item
        {
            Id = Guid.Parse("23EFBE5B-85F8-4B72-8759-91C422F7DF6D"),
            Name = "Plaster",
            Price = (decimal)19.15,
        };
        public static Item CONCRETE = new Item
        {
            Id = Guid.Parse("20DF1DC4-23F6-4F66-8D3F-121BE73B1512"),
            Name = "Concrete",
            Price = (decimal)27.45,
        };
        public static Item DRILL = new Item
        {
            Id = Guid.Parse("1BA6D682-5EC9-43AB-A3CE-091F6B1B3B5B"),
            Name = "Drill",
            Price = (decimal)70.75,
        };
        public static Item PAINT = new Item
        {
            Id = Guid.Parse("51A6F835-CA47-447B-9439-4151B9305894"),
            Name = "Paint",
            Price = (decimal)8.57,
        };
        public static Item LADDER = new Item
        {
            Id = Guid.Parse("2BAAF25F-FA3E-474F-8448-418215797114"),
            Name = "Ladder",
            Price = (decimal)20.45,
        };
        public static Item PALLET = new Item
        {
            Id = Guid.Parse("BE5DD507-3B1D-4079-B513-BAAAB5D795A4"),
            Name = "Pallet",
            Price = (decimal)9.39,
        };
        public static Item GRINDER = new Item
        {
            Id = Guid.Parse("D95A87FD-EF9C-41BF-B6E5-DA2C6D2C7D5D"),
            Name = "Grinder",
            Price = (decimal)59.31,
        };
        public static Item PADLOCK = new Item
        {
            Id = Guid.Parse("B97DCE86-2974-439C-BA7B-4A37B653A368"),
            Name = "Padlock",
            Price = (decimal)7.12
        };
        public static Item TOOLBOX = new Item
        {
            Id = Guid.Parse("C169B1EF-958E-4470-8D6F-26EDE6C0FD9E"),
            Name = "Toolbox",
            Price = (decimal)20.61
        };
        public static Item LIGHTER = new Item
        {
            Id = Guid.Parse("4A1C3021-9B22-4140-89C0-24435AB950A8"),
            Name = "Lighter",
            Price = (decimal)8.50
        };
        public static Item NAILS = new Item
        {
            Id = Guid.Parse("B8AC3C9F-DA9A-481F-BDDF-021B61611D38"),
            Name = "Nails",
            Price = (decimal)5.05
        };
        public static Item HINGES = new Item
        {
            Id = Guid.Parse("3C7A417D-B948-4501-BED2-87F43ABC228D"),
            Name = "Hinges",
            Price = (decimal)1.84
        };
        public static Item WIRES = new Item
        {
            Id = Guid.Parse("9E1F9819-CB69-4DC0-B260-46DD1FE283EC"),
            Name = "Wires",
            Price = (decimal)14.37
        };
        public static Item GLUE = new Item
        {
            Id = Guid.Parse("E3839AE4-B822-4F94-96B8-FF9670D60678"),
            Name = "Glue",
            Price = (decimal)2.75
        };
        public static Item SAW = new Item
        {
            Id = Guid.Parse("F3DAB57D-A34B-4705-9700-74FF427DD0FB"),
            Name = "Saw",
            Price = (decimal)43.87
        };

        public static void Seed()
        {
            var context = new ApplicationDBContext();
            var dbItems = context.Items.ToList();
            var itemIds = dbItems.Select(x => x.Id).ToList();

            var items = new List<Item>
            {
                CHAIN, ADHESIVES, WRENCH, TAP, BELT, BATTERIES, 
                HAMMER, AXE, PIPE, CEMENT, PLASTER, CONCRETE, 
                DRILL, PAINT, LADDER, PALLET, GRINDER, PADLOCK, 
                TOOLBOX, LIGHTER, NAILS, HINGES, WIRES, GLUE, SAW
            };

            var Ids = items.Select(x => x.Id).ToList();

            if (!dbItems.Select(x => x.Id).Intersect(Ids).Any())
            {
                context.Items.AddRange(items);
                context.SaveChanges();
            }
        }
    }
}
