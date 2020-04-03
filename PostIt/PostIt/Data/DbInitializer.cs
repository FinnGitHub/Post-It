using PostIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostIt.Data
{
    public class DbInitializer
    {
        public static void Initialize(PostContext context)
        {
            context.Database.EnsureCreated();

            // Look for any events.
            if (context.Posts.Any())
            {
                return;   // DB has been seeded
            }
            var posts = new Post[]
            {
                new Post{PostName="Bordspellenavond!",
                    Description="Ja hoor!! We zetten onverminderd door met de mega-succesvolle bordspellenavond… " +
                        "Neem je spellen mee, en je partner, vriend of zus. Eet je mee? Laat dit dan even weten aan onze ultieme spelleider Sven Klaassen Bos!",
                    Categories="Eindhoven",ImageSrc="Bordspel.jpg"},

                new Post{PostName="Pizzasessie IT Rockstar Sven Haster | Four easy steps to migrate to JPMS",
                    Description="Vanuit Chapter East introduceren wij IT Rockstar Sven Haster!! Op 15 April aanstaande zal hij zijn sessie “Four easy steps " +
                        "to migrate to JPMS” geven in Jules Verne in Apeldoorn. Hier wil je bij zijn! Java 9 introduceerde het Java module system, ook wel project " +
                        "Jigsaw genoemd. Voor veel ontwikkelaars is dit nog een abstract en ondoorzichtig geheel en dit is dan ook dé reden dat veel projecten nog op Java 8 zitten. " +
                        "In deze presentatie laat IT Rockstar Sven vier simpele stappen zien om je project JPMS compliant te maken en naar Java 9+ te migreren.",
                    Categories="Apeldoorn",ImageSrc="SvenHaster.jpg"},

                new Post{PostName="IT Rockstar Christiaan Nieuwlaat | Modulaire Software Ontwikkeling – Chapter Lower South",
                    Description="And he does it again!! Op 16 April zal IT Rockstar een sessie verzorgen over Modulaire Software Ontwikkeling. " +
                        "Dit doet hij in het vertrouwde thuishonk van chapter Lower South; Doloris in Tilburg. Steeds meer systemen worden op een manier opgebouwd zodat deze " +
                        "bestaan uit “herbruikbare” onderdelen. Dit gebeurt op macro niveau, het ombouwen van een monoliet naar microservices, maar ook op micro niveau, het " +
                        "gebruik maken van modules als bibliotheken, bijvoorbeeld in de vorm van java 9+ modules. We gaan het hebben over deze verschillende niveaus, waarom we " +
                        "gebruik willen maken van modulaire ontwikkeling en wat de voor- en nadelen hiervan zijn.",
                    Categories="Tilburg",ImageSrc="ChristiaanNieuwlaat.jpg"},

                new Post{PostName="Pizzasessie IT Rockstar Bart Kardol | Digitalisering verandert de wereld, ook op zee",
                    Description="n chapter Upper South hebben we IT Rockstar gepland staan op 22 April voor een supervette sessie: “Digitalisering verandert de wereld, ook op zee”. " +
                    "Catchy titel, nietwaar? Inschrijven voor zijn sessie doe je hier! Het event vindt plaats op Team Rockstars IT HQ in ‘s-Hertogenbosch!",
                    Categories="Den Bosch",ImageSrc="BartKardol.jpg"},
            };

            foreach (Post e in posts)
            {
                context.Posts.Add(e);
            }
            context.SaveChanges();
        }

    }
}
