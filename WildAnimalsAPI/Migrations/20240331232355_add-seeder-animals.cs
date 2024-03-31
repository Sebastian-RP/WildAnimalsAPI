using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WildAnimalsAPI.Migrations
{
    /// <inheritdoc />
    public partial class addseederanimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AverageHeightMax", "AverageHeightMin", "AverageLifespanMax", "AverageLifespanMin", "AverageSpeedMax", "AverageSpeedMin", "AverageWeightMax", "AverageWeightMin", "CommonName", "Description", "Diet", "EstimatedPopulationSize", "Locations", "ScientificName" },
                values: new object[,]
                {
                    { 1, 38, 28, 20, 15, 100, 55, 14, 6, "Bald Eagle", "The bald eagle is a large bird of prey native to North America. It has a distinctive white head and brown body, and is known for its exceptional eyesight and hunting abilities.", "Carnivore", 150000, "3", "haliaeetus leucocephalus" },
                    { 2, 16, 13, 15, 10, 15, 10, 30, 18, "Beagle", "The Beagle is a breed of small, compact dogs that are known for their gentle and friendly nature, as well as their exceptional sense of smell.", "Omnivore", 1000000, "6", "Canis lupus" },
                    { 3, 24, 18, 14, 10, 20, 15, 70, 40, "Beagle Shepherd", "The Beagle Shepherd is a hybrid breed that combines the intelligence and protective nature of the German Shepherd with the friendly and playful character of the Beagle.", "Omnivore", 10000, "3", "Canis lupus" },
                    { 4, 16, 12, 14, 10, 15, 10, 25, 15, "Cheagle", "The Cheagle is a hybrid breed that combines the playful and affectionate nature of the Beagle with the loyalty and intelligence of the Chihuahua.", "Omnivore", 5000, "3", "Canis lupus" },
                    { 5, 100, 40, 30, 15, 100, 60, 15, 2, "Eagle", "Eagles are large birds of prey that belong to the family Accipitridae. They are known for their powerful wings, sharp talons, and excellent eyesight, which make them skilled hunters.", "Carnivore", 1000000, "2;1;6;3;4", "Accipitridae" },
                    { 6, 102, 89, 35, 25, 50, 30, 20, 11, "Harpy Eagle", "The Harpy Eagle is one of the largest and most powerful birds of prey in the world, found in the tropical forests of Central and South America.", "Carnivore", 50000, "3;4", "Harpia harpyja" },
                    { 7, 16, 12, 15, 12, 15, 10, 30, 20, "Malteagle", "The Malteagle is a hybrid breed that combines the playful and affectionate nature of the Maltese with the intelligence and loyalty of the Beagle.", "Omnivore", 2000, "3", "Canis lupus" },
                    { 8, 16, 12, 15, 10, 15, 10, 25, 15, "Meagle", "The Meagle is a hybrid breed that combines the friendly and playful nature of the Beagle with the intelligence and alertness of the Miniature Schnauzer.", "Omnivore", 3000, "3", "Canis lupus" },
                    { 9, 65, 50, 26, 20, 40, 30, 4, 3, "Mexican Eagle (Northern crested caracara)", "The Northern Crested Caracara, also known as the Mexican Eagle, is a unique bird of prey found in the southern United States, Mexico, and Central America.", "Carnivore", 100000, "3;4", "Caracara cheriway" },
                    { 10, 16, 12, 14, 12, 15, 10, 20, 15, "Peagle", "The Peagle is a hybrid breed that combines the friendly and playful nature of the Beagle with the intelligence and alertness of the Pug.", "Omnivore", 4000, "3", "Canis lupus" },
                    { 11, 14, 10, 15, 10, 15, 10, 20, 10, "Pocket Beagle", "The Pocket Beagle is a miniature version of the classic Beagle breed, known for its friendly and curious nature, as well as its compact size.", "Omnivore", 20000, "6", "Canis lupus" },
                    { 12, 18, 14, 15, 12, 15, 10, 30, 20, "Pomeagle", "The Pomeagle is a hybrid breed that combines the friendly and playful nature of the Beagle with the intelligence and affection of the Pomeranian.", "Omnivore", 2500, "3", "Canis lupus" },
                    { 13, 360, 150, 30, 20, 20, 10, 500, 100, "Porbeagle Shark", "The Porbeagle Shark is a large, robust shark species found in the cold and temperate waters of the North Atlantic and Southern Hemisphere oceans.", "Carnivore", 200000, "7", "Lamna nasus" },
                    { 14, 18, 14, 15, 12, 15, 10, 30, 20, "Schneagle", "The Schneagle is a hybrid breed that combines the friendly and playful nature of the Beagle with the intelligence and alertness of the Miniature Schnauzer.", "Omnivore", 3500, "3", "Canis lupus" },
                    { 15, 100, 60, 25, 15, 98, 50, 9, 2, "Sea Eagle", "Sea eagles are large birds of prey that belong to the genus Haliaeetus and are found near coastal regions around the world.", "Carnivore", 1000000, "2;5;1;6;3;7", "Haliaeetus" },
                    { 16, 94, 66, 25, 20, 46, 30, 6, 4, "White-Tailed Eagle", "The White-Tailed Eagle is a large bird of prey found in Eurasia and North America, known for its distinctive white tail and impressive wingspan.", "Carnivore", 30000, "1;6;3", "Haliaeetus albicilla" },
                    { 17, 84, 60, 20, 10, 30, 20, 90, 29, "Cougar", "El puma o cougar es el felino más grande de América del Norte, conocido por sus poderosas extremidades delanteras, patas y mandíbulas musculares.", "Carnivore", 30000, "3", "Felis Concolor" },
                    { 18, 74, 48, 25, 15, 25, 15, 115, 90, "Asiatic Black Bear", "El oso negro asiático, también conocido como oso negro del Himalaya o oso luna, es un oso omnívoro que habita en los bosques tropicales caducifolios del sur y centro de Asia. Se caracteriza por su distintiva marca en forma de 'V' en el pecho.", "Omnivore", 50000, "1", "Ursus tibetanus" },
                    { 19, 109, 59, 30, 20, 35, 25, 390, 136, "Brown Bear", "El oso pardo o oso grizzly es una poderosa especie de oso omnívoro que habita en las regiones forestales y montañosas del hemisferio norte. Se caracteriza por su fuerza, garras afiladas y hábito hibernante.", "Omnivore", 200000, "1;6;3", "Ursus arctos" },
                    { 20, 70, 59, 35, 20, 20, 10, 250, 110, "Giant Panda Bear", "El oso panda gigante es una especie única de oso herbívoro que habita en las montañas del centro de China. Se caracteriza por su distintivo pelaje blanco y negro, y su habilidad para consumir bambú.", "Omnivore", 2000, "1", "Ailuropoda melanoleuca" },
                    { 21, 118, 84, 25, 15, 35, 25, 318, 181, "Grizzly Bear", "El oso grizzly o oso pardo es una subespecie del oso pardo conocido por su gran tamaño, fuerza y garras enormes. Habita en las regiones forestales y montañosas del oeste de América del Norte.", "Omnivore", 50000, "3", "Ursus Arctos Horriblis" },
                    { 22, 70, 51, 30, 15, 30, 20, 270, 100, "North American Black Bear", "El oso negro americano es una especie de oso omnívoro que habita en las regiones boscosas y arboladas de América del Norte. Se caracteriza por su grueso pelaje y hocico puntiagudo.", "Omnivore", 800000, "3", "Ursus americanus" },
                    { 23, 98, 78, 30, 20, 25, 15, 600, 150, "Polar Bear", "El oso polar es una especie de oso carnívoro que habita en las regiones costeras y campos de hielo del Ártico. Se caracteriza por su pelaje blanco y piel negra, adaptado al entorno ártico.", "Carnivore", 22500, "1;6;3;7", "Ursus maritimus" },
                    { 24, 78, 59, 30, 20, 30, 20, 200, 130, "Spectacled Bear", "El oso de anteojos o oso andino es una especie de oso omnívoro que habita en las regiones costeras y desérticas de los Andes en Sudamérica. Se caracteriza por sus distintivas marcas claras alrededor de los ojos.", "Omnivore", 20000, "4", "Tremarctos Ornatus" },
                    { 25, 59, 47, 30, 15, 30, 20, 60, 30, "Sun Bear", "El oso malayo o oso de las mieles es la especie más pequeña de oso existente. Habita en los bosques tropicales del sureste asiático y se caracteriza por su distintiva marca en forma de 'U' en el pecho.", "Omnivore", 10000, "1", "Helarctos malayanus" },
                    { 26, 31, 20, 15, 12, 34, 24, 33, 9, "Bobcat", "El lince rojo o gato bobcat es un felino de tamaño mediano que habita en América del Norte y algunas regiones de América Central. Se caracteriza por sus distintivas orejas con penachos y su cola corta.", "Carnivore", 1000000, "3", "Lynx rufus" },
                    { 27, 71, 60, 35, 20, 20, 10, 551, 242, "Giant Panda Bear", "El oso panda gigante es una especie única de oso herbívoro que habita en las montañas del centro de China. Se caracteriza por su distintivo pelaje blanco y negro, y su habilidad para consumir bambú.", "Omnivore", 2000, "1", "Ailuropoda melanoleuca" },
                    { 28, 47, 24, 12, 8, 24, 14, 14, 7, "Red Panda", "La panda roja o panda menor es una especie de mamífero omnívoro que habita en las montañas del Himalaya. Se caracteriza por su grueso pelaje rojizo y cara rayada.", "Omnivore", 3000, "1", "Ailurus fulgens" },
                    { 29, 0, 0, 50, 45, 40, 40, 3100, 1800, "Black Rhinoceros", "You can replace this with a description retrieved from the web about Black Rhinoceros.", "Herbivore", 0, "2", "Diceros Bicornis" },
                    { 30, 0, 0, 50, 45, 30, 30, 6600, 4900, "Indian Rhinoceros", "You can replace this with a description retrieved from the web about Indian Rhinoceros.", "Herbivore", 0, "1", "Rhinoceros Unicornis" },
                    { 31, 0, 0, 50, 45, 30, 30, 7920, 3168, "White Rhinoceros", "You can replace this with a description retrieved from the web about White Rhinoceros.", "Herbivore", 0, "2", "Ceratotherium simum" },
                    { 32, 350, 300, 70, 60, 25, 25, 5400, 3600, "African Bush Elephant", "The African Bush Elephant is the largest living land animal.  They have large,扇形 (shàn xíng - fan-shaped) ears to help radiate heat and wrinkled gray skin.  Their tusks are long and curved outwards.  These gentle giants are social creatures living in herds led by females.", "Herbivore", 300000, "2", "Loxodonta africana africana" },
                    { 33, 300, 200, 70, 60, 24, 24, 3000, 900, "African Forest Elephant", "The African Forest Elephant is smaller and darker than its savanna relative.  They have characteristically rounded ears and a hairy trunk.  An African forest elephant's tusks are straighter and point downward, rather outwards like savanna elephants.  They play a vital role in seed dispersal by consuming a diet rich in fruits.", "Herbivore", 200000, "2", "Loxodonta cyclotis" },
                    { 34, 20, 17, 10, 6, 32, 24, 30, 20, "Pájaro Azul Oriental", "Un ave cantora pequeña y colorida que habita en bosques abiertos y áreas suburbanas de América del Norte. Se caracteriza por su plumaje azul brillante en los machos y azul más pálido en las hembras.", "Omnívora (fruta favorita)", 900000, "3", "Sialia sialis" },
                    { 35, 10, 5, 8, 3, 90, 50, 6, 2, "Colibrí", "Las aves más pequeñas del mundo, conocidas por su vuelo acrobático y su capacidad para alimentarse de néctar. Se encuentran en diversos hábitats de América Central, Norte y Sur.", "Nectarívora", 340, "3;4", "Familia Trochilidae" },
                    { 36, 10, 5, 8, 3, 90, 50, 6, 2, "Colibrí Rubí Garganta", "Un colibrí de tamaño mediano con garganta roja brillante. Habita en bosques, jardines y campos de América del Norte. Construye nidos con telarañas y líquenes.", "Nectarívora", 36000000, "3", "Archilochus colubris" },
                    { 37, 129, 48, 35, 15, 35, 20, 450, 27, "Bear", "Los osos son mamíferos omnívoros de la familia Ursidae, conocidos por su gran tamaño, fuerza y garras afiladas. Habitan en regiones forestales y montañosas de diferentes partes del mundo.", "Omnivore", 1000000, "1;6;3;4", "Ursidae" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 37);
        }
    }
}
