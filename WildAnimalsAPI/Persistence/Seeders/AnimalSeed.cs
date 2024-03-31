using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WildAnimalsAPI.Models;

namespace WildAnimalsAPI.Persistence.Seeders
{
    public class AnimalSeed : IEntityTypeConfiguration<Animal>
    {
    //para completar estos registros saque la informacion de la api de animales de NinjaApi y algunos asistentes IA, asi que algunos datos o apuntes pueden ser algo desacertados 
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasData(
                new Animal
                {
                    Id = 1,
                    CommonName = "Bald Eagle",
                    ScientificName = "haliaeetus leucocephalus",
                    AverageHeightMin = 28,
                    AverageHeightMax = 38,
                    Description = "The bald eagle is a large bird of prey native to North America. It has a distinctive white head and brown body, and is known for its exceptional eyesight and hunting abilities.",
                    AverageSpeedMin = 55,
                    AverageSpeedMax = 100,
                    AverageWeightMin = 6,
                    AverageWeightMax = 14,
                    EstimatedPopulationSize = 150000,
                    AverageLifespanMin = 15,
                    AverageLifespanMax = 20,
                    Diet = "Carnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 2,
                    CommonName = "Beagle",
                    ScientificName = "Canis lupus",
                    AverageHeightMin = 13,
                    AverageHeightMax = 16,
                    Description = "The Beagle is a breed of small, compact dogs that are known for their gentle and friendly nature, as well as their exceptional sense of smell.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 15,
                    AverageWeightMin = 18,
                    AverageWeightMax = 30,
                    EstimatedPopulationSize = 1000000,
                    AverageLifespanMin = 10,
                    AverageLifespanMax = 15,
                    Diet = "Omnivore",
                    Locations = "6"
                },
                new Animal
                {
                    Id = 3,
                    CommonName = "Beagle Shepherd",
                    ScientificName = "Canis lupus",
                    AverageHeightMin = 18,
                    AverageHeightMax = 24,
                    Description = "The Beagle Shepherd is a hybrid breed that combines the intelligence and protective nature of the German Shepherd with the friendly and playful character of the Beagle.",
                    AverageSpeedMin = 15,
                    AverageSpeedMax = 20,
                    AverageWeightMin = 40,
                    AverageWeightMax = 70,
                    EstimatedPopulationSize = 10000,
                    AverageLifespanMin = 10,
                    AverageLifespanMax = 14,
                    Diet = "Omnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 4,
                    CommonName = "Cheagle",
                    ScientificName = "Canis lupus",
                    AverageHeightMin = 12,
                    AverageHeightMax = 16,
                    Description = "The Cheagle is a hybrid breed that combines the playful and affectionate nature of the Beagle with the loyalty and intelligence of the Chihuahua.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 15,
                    AverageWeightMin = 15,
                    AverageWeightMax = 25,
                    EstimatedPopulationSize = 5000,
                    AverageLifespanMin = 10,
                    AverageLifespanMax = 14,
                    Diet = "Omnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 5,
                    CommonName = "Eagle",
                    ScientificName = "Accipitridae",
                    AverageHeightMin = 40,
                    AverageHeightMax = 100,
                    Description = "Eagles are large birds of prey that belong to the family Accipitridae. They are known for their powerful wings, sharp talons, and excellent eyesight, which make them skilled hunters.",
                    AverageSpeedMin = 60,
                    AverageSpeedMax = 100,
                    AverageWeightMin = 2,
                    AverageWeightMax = 15,
                    EstimatedPopulationSize = 1000000,
                    AverageLifespanMin = 15,
                    AverageLifespanMax = 30,
                    Diet = "Carnivore",
                    Locations = "2;1;6;3;4"
                },
                new Animal
                {
                    Id = 6,
                    CommonName = "Harpy Eagle",
                    ScientificName = "Harpia harpyja",
                    AverageHeightMin = 89,
                    AverageHeightMax = 102,
                    Description = "The Harpy Eagle is one of the largest and most powerful birds of prey in the world, found in the tropical forests of Central and South America.",
                    AverageSpeedMin = 30,
                    AverageSpeedMax = 50,
                    AverageWeightMin = 11,
                    AverageWeightMax = 20,
                    EstimatedPopulationSize = 50000,
                    AverageLifespanMin = 25,
                    AverageLifespanMax = 35,
                    Diet = "Carnivore",
                    Locations = "3;4"
                },
                new Animal
                {
                    Id = 7,
                    CommonName = "Malteagle",
                    ScientificName = "Canis lupus",
                    AverageHeightMin = 12,
                    AverageHeightMax = 16,
                    Description = "The Malteagle is a hybrid breed that combines the playful and affectionate nature of the Maltese with the intelligence and loyalty of the Beagle.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 15,
                    AverageWeightMin = 20,
                    AverageWeightMax = 30,
                    EstimatedPopulationSize = 2000,
                    AverageLifespanMin = 12,
                    AverageLifespanMax = 15,
                    Diet = "Omnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 8,
                    CommonName = "Meagle",
                    ScientificName = "Canis lupus",
                    AverageHeightMin = 12,
                    AverageHeightMax = 16,
                    Description = "The Meagle is a hybrid breed that combines the friendly and playful nature of the Beagle with the intelligence and alertness of the Miniature Schnauzer.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 15,
                    AverageWeightMin = 15,
                    AverageWeightMax = 25,
                    EstimatedPopulationSize = 3000,
                    AverageLifespanMin = 10,
                    AverageLifespanMax = 15,
                    Diet = "Omnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 9,
                    CommonName = "Mexican Eagle (Northern crested caracara)",
                    ScientificName = "Caracara cheriway",
                    AverageHeightMin = 50,
                    AverageHeightMax = 65,
                    Description = "The Northern Crested Caracara, also known as the Mexican Eagle, is a unique bird of prey found in the southern United States, Mexico, and Central America.",
                    AverageSpeedMin = 30,
                    AverageSpeedMax = 40,
                    AverageWeightMin = 3,
                    AverageWeightMax = 4,
                    EstimatedPopulationSize = 100000,
                    AverageLifespanMin = 20,
                    AverageLifespanMax = 26,
                    Diet = "Carnivore",
                    Locations = "3;4"
                },
                new Animal
                {
                    Id = 10,
                    CommonName = "Peagle",
                    ScientificName = "Canis lupus",
                    AverageHeightMin = 12,
                    AverageHeightMax = 16,
                    Description = "The Peagle is a hybrid breed that combines the friendly and playful nature of the Beagle with the intelligence and alertness of the Pug.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 15,
                    AverageWeightMin = 15,
                    AverageWeightMax = 20,
                    EstimatedPopulationSize = 4000,
                    AverageLifespanMin = 12,
                    AverageLifespanMax = 14,
                    Diet = "Omnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 11,
                    CommonName = "Pocket Beagle",
                    ScientificName = "Canis lupus",
                    AverageHeightMin = 10,
                    AverageHeightMax = 14,
                    Description = "The Pocket Beagle is a miniature version of the classic Beagle breed, known for its friendly and curious nature, as well as its compact size.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 15,
                    AverageWeightMin = 10,
                    AverageWeightMax = 20,
                    EstimatedPopulationSize = 20000,
                    AverageLifespanMin = 10,
                    AverageLifespanMax = 15,
                    Diet = "Omnivore",
                    Locations = "6"
                },
                new Animal
                {
                    Id = 12,
                    CommonName = "Pomeagle",
                    ScientificName = "Canis lupus",
                    AverageHeightMin = 14,
                    AverageHeightMax = 18,
                    Description = "The Pomeagle is a hybrid breed that combines the friendly and playful nature of the Beagle with the intelligence and affection of the Pomeranian.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 15,
                    AverageWeightMin = 20,
                    AverageWeightMax = 30,
                    EstimatedPopulationSize = 2500,
                    AverageLifespanMin = 12,
                    AverageLifespanMax = 15,
                    Diet = "Omnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 13,
                    CommonName = "Porbeagle Shark",
                    ScientificName = "Lamna nasus",
                    AverageHeightMin = 150,
                    AverageHeightMax = 360,
                    Description = "The Porbeagle Shark is a large, robust shark species found in the cold and temperate waters of the North Atlantic and Southern Hemisphere oceans.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 20,
                    AverageWeightMin = 100,
                    AverageWeightMax = 500,
                    EstimatedPopulationSize = 200000,
                    AverageLifespanMin = 20,
                    AverageLifespanMax = 30,
                    Diet = "Carnivore",
                    Locations = "7"
                },
                new Animal
                {
                    Id = 14,
                    CommonName = "Schneagle",
                    ScientificName = "Canis lupus",
                    AverageHeightMin = 14,
                    AverageHeightMax = 18,
                    Description = "The Schneagle is a hybrid breed that combines the friendly and playful nature of the Beagle with the intelligence and alertness of the Miniature Schnauzer.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 15,
                    AverageWeightMin = 20,
                    AverageWeightMax = 30,
                    EstimatedPopulationSize = 3500,
                    AverageLifespanMin = 12,
                    AverageLifespanMax = 15,
                    Diet = "Omnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 15,
                    CommonName = "Sea Eagle",
                    ScientificName = "Haliaeetus",
                    AverageHeightMin = 60,
                    AverageHeightMax = 100,
                    Description = "Sea eagles are large birds of prey that belong to the genus Haliaeetus and are found near coastal regions around the world.",
                    AverageSpeedMin = 50,
                    AverageSpeedMax = 98,
                    AverageWeightMin = 2,
                    AverageWeightMax = 9,
                    EstimatedPopulationSize = 1000000,
                    AverageLifespanMin = 15,
                    AverageLifespanMax = 25,
                    Diet = "Carnivore",
                    Locations = "2;5;1;6;3;7"
                },
                new Animal
                {
                    Id = 16,
                    CommonName = "White-Tailed Eagle",
                    ScientificName = "Haliaeetus albicilla",
                    AverageHeightMin = 66,
                    AverageHeightMax = 94,
                    Description = "The White-Tailed Eagle is a large bird of prey found in Eurasia and North America, known for its distinctive white tail and impressive wingspan.",
                    AverageSpeedMin = 30,
                    AverageSpeedMax = 46,
                    AverageWeightMin = 4,
                    AverageWeightMax = 6,
                    EstimatedPopulationSize = 30000,
                    AverageLifespanMin = 20,
                    AverageLifespanMax = 25,
                    Diet = "Carnivore",
                    Locations = "1;6;3"
                },
                new Animal
                {
                    Id = 17,
                    CommonName = "Cougar",
                    ScientificName = "Felis Concolor",
                    AverageHeightMin = 60, // Aproximadamente 2 pies (1.5m / 3.28)
                    AverageHeightMax = 84, // Aproximadamente 2.75 pies (2.75m / 3.28)
                    Description = "El puma o cougar es el felino más grande de América del Norte, conocido por sus poderosas extremidades delanteras, patas y mandíbulas musculares.",
                    AverageSpeedMin = 20,
                    AverageSpeedMax = 30,
                    AverageWeightMin = 29, //Kg
                    AverageWeightMax = 90,
                    EstimatedPopulationSize = 30000, // Estimación
                    AverageLifespanMin = 10,
                    AverageLifespanMax = 20,
                    Diet = "Carnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 18,
                    CommonName = "Asiatic Black Bear",
                    ScientificName = "Ursus tibetanus",
                    AverageHeightMin = 48, // 1.2m
                    AverageHeightMax = 74, // 1.9m
                    Description = "El oso negro asiático, también conocido como oso negro del Himalaya o oso luna, es un oso omnívoro que habita en los bosques tropicales caducifolios del sur y centro de Asia. Se caracteriza por su distintiva marca en forma de 'V' en el pecho.",
                    AverageSpeedMin = 15,
                    AverageSpeedMax = 25,
                    AverageWeightMin = 90,
                    AverageWeightMax = 115,
                    EstimatedPopulationSize = 50000,
                    AverageLifespanMin = 15,
                    AverageLifespanMax = 25,
                    Diet = "Omnivore",
                    Locations = "1"
                },
                new Animal
                {
                    Id = 19,
                    CommonName = "Brown Bear",
                    ScientificName = "Ursus arctos",
                    AverageHeightMin = 59, // 1.5m
                    AverageHeightMax = 109, // 2.8m
                    Description = "El oso pardo o oso grizzly es una poderosa especie de oso omnívoro que habita en las regiones forestales y montañosas del hemisferio norte. Se caracteriza por su fuerza, garras afiladas y hábito hibernante.",
                    AverageSpeedMin = 25,
                    AverageSpeedMax = 35,
                    AverageWeightMin = 136,
                    AverageWeightMax = 390,
                    EstimatedPopulationSize = 200000, // Estimación
                    AverageLifespanMin = 20,
                    AverageLifespanMax = 30,
                    Diet = "Omnivore",
                    Locations = "1;6;3"
                },
                new Animal
                {
                    Id = 20,
                    CommonName = "Giant Panda Bear",
                    ScientificName = "Ailuropoda melanoleuca",
                    AverageHeightMin = 59, // 1.5m
                    AverageHeightMax = 70, // 1.8m
                    Description = "El oso panda gigante es una especie única de oso herbívoro que habita en las montañas del centro de China. Se caracteriza por su distintivo pelaje blanco y negro, y su habilidad para consumir bambú.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 20,
                    AverageWeightMin = 110,
                    AverageWeightMax = 250,
                    EstimatedPopulationSize = 2000,
                    AverageLifespanMin = 20,
                    AverageLifespanMax = 35,
                    Diet = "Omnivore",
                    Locations = "1"
                },
                new Animal
                {
                    Id = 21,
                    CommonName = "Grizzly Bear",
                    ScientificName = "Ursus Arctos Horriblis",
                    AverageHeightMin = 84, // 2.1m
                    AverageHeightMax = 118, // 3m
                    Description = "El oso grizzly o oso pardo es una subespecie del oso pardo conocido por su gran tamaño, fuerza y garras enormes. Habita en las regiones forestales y montañosas del oeste de América del Norte.",
                    AverageSpeedMin = 25,
                    AverageSpeedMax = 35,
                    AverageWeightMin = 181,
                    AverageWeightMax = 318,
                    EstimatedPopulationSize = 50000, // Estimación
                    AverageLifespanMin = 15,
                    AverageLifespanMax = 25,
                    Diet = "Omnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 22,
                    CommonName = "North American Black Bear",
                    ScientificName = "Ursus americanus",
                    AverageHeightMin = 51, // 1.3m
                    AverageHeightMax = 70, // 1.8m
                    Description = "El oso negro americano es una especie de oso omnívoro que habita en las regiones boscosas y arboladas de América del Norte. Se caracteriza por su grueso pelaje y hocico puntiagudo.",
                    AverageSpeedMin = 20,
                    AverageSpeedMax = 30,
                    AverageWeightMin = 100,
                    AverageWeightMax = 270,
                    EstimatedPopulationSize = 800000,
                    AverageLifespanMin = 15,
                    AverageLifespanMax = 30,
                    Diet = "Omnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 23,
                    CommonName = "Polar Bear",
                    ScientificName = "Ursus maritimus",
                    AverageHeightMin = 78, // 2m
                    AverageHeightMax = 98, // 2.5m
                    Description = "El oso polar es una especie de oso carnívoro que habita en las regiones costeras y campos de hielo del Ártico. Se caracteriza por su pelaje blanco y piel negra, adaptado al entorno ártico.",
                    AverageSpeedMin = 15,
                    AverageSpeedMax = 25,
                    AverageWeightMin = 150,
                    AverageWeightMax = 600,
                    EstimatedPopulationSize = 22500, // Promedio del rango proporcionado
                    AverageLifespanMin = 20,
                    AverageLifespanMax = 30,
                    Diet = "Carnivore",
                    Locations = "1;6;3;7"
                },
                new Animal
                {
                    Id = 24,
                    CommonName = "Spectacled Bear",
                    ScientificName = "Tremarctos Ornatus",
                    AverageHeightMin = 59, // 1.5m
                    AverageHeightMax = 78, // 2m
                    Description = "El oso de anteojos o oso andino es una especie de oso omnívoro que habita en las regiones costeras y desérticas de los Andes en Sudamérica. Se caracteriza por sus distintivas marcas claras alrededor de los ojos.",
                    AverageSpeedMin = 20,
                    AverageSpeedMax = 30,
                    AverageWeightMin = 130,
                    AverageWeightMax = 200,
                    EstimatedPopulationSize = 20000, // Estimación
                    AverageLifespanMin = 20,
                    AverageLifespanMax = 30,
                    Diet = "Omnivore",
                    Locations = "4"
                },
                new Animal
                {
                    Id = 25,
                    CommonName = "Sun Bear",
                    ScientificName = "Helarctos malayanus",
                    AverageHeightMin = 47, // 1.2m
                    AverageHeightMax = 59, // 1.5m
                    Description = "El oso malayo o oso de las mieles es la especie más pequeña de oso existente. Habita en los bosques tropicales del sureste asiático y se caracteriza por su distintiva marca en forma de 'U' en el pecho.",
                    AverageSpeedMin = 20,
                    AverageSpeedMax = 30,
                    AverageWeightMin = 30,
                    AverageWeightMax = 60,
                    EstimatedPopulationSize = 10000, // Estimación
                    AverageLifespanMin = 15,
                    AverageLifespanMax = 30,
                    Diet = "Omnivore",
                    Locations = "1"
                },
                new Animal
                {
                    Id = 26,
                    CommonName = "Bobcat",
                    ScientificName = "Lynx rufus",
                    AverageHeightMin = 20, // Aproximadamente 25 pulgadas (65cm / 2.54)
                    AverageHeightMax = 31, // Aproximadamente 40 pulgadas (100cm / 2.54)
                    Description = "El lince rojo o gato bobcat es un felino de tamaño mediano que habita en América del Norte y algunas regiones de América Central. Se caracteriza por sus distintivas orejas con penachos y su cola corta.",
                    AverageSpeedMin = 24,
                    AverageSpeedMax = 34,
                    AverageWeightMin = 9, // 4.1 kg
                    AverageWeightMax = 33, // 15.3 kg
                    EstimatedPopulationSize = 1000000,
                    AverageLifespanMin = 12,
                    AverageLifespanMax = 15,
                    Diet = "Carnivore",
                    Locations = "3"
                },
                new Animal
                {
                    Id = 27,
                    CommonName = "Giant Panda Bear", 
                    ScientificName = "Ailuropoda melanoleuca",
                    AverageHeightMin = 60, // 1.5m
                    AverageHeightMax = 71, // 1.8m 
                    Description = "El oso panda gigante es una especie única de oso herbívoro que habita en las montañas del centro de China. Se caracteriza por su distintivo pelaje blanco y negro, y su habilidad para consumir bambú.",
                    AverageSpeedMin = 10,
                    AverageSpeedMax = 20,
                    AverageWeightMin = 242, // 110kg
                    AverageWeightMax = 551, // 250kg
                    EstimatedPopulationSize = 2000,
                    AverageLifespanMin = 20,
                    AverageLifespanMax = 35,
                    Diet = "Omnivore",
                    Locations = "1"
                },
                new Animal
                {
                    Id = 28,
                    CommonName = "Red Panda",
                    ScientificName = "Ailurus fulgens",
                    AverageHeightMin = 24, // Aproximadamente 60cm
                    AverageHeightMax = 47, // Aproximadamente 120cm
                    Description = "La panda roja o panda menor es una especie de mamífero omnívoro que habita en las montañas del Himalaya. Se caracteriza por su grueso pelaje rojizo y cara rayada.",
                    AverageSpeedMin = 14,
                    AverageSpeedMax = 24,
                    AverageWeightMin = 7, // 3kg
                    AverageWeightMax = 14, // 6.2kg
                    EstimatedPopulationSize = 3000, // Se indica "less than 3,000"
                    AverageLifespanMin = 8,
                    AverageLifespanMax = 12,
                    Diet = "Omnivore",
                    Locations = "1"
                },
                new Animal
                {
                    Id = 29,
                    CommonName = "Black Rhinoceros",
                    ScientificName = "Diceros Bicornis",
                    AverageHeightMin = 0, // Information not available in the data
                    AverageHeightMax = 0, // Information not available in the data
                    Description = "You can replace this with a description retrieved from the web about Black Rhinoceros.",  // Description not available in the data
                    AverageSpeedMin = 40,
                    AverageSpeedMax = 40,
                    AverageWeightMin = 1800, // Converted from kilograms (800kg)
                    AverageWeightMax = 3100, // Converted from kilograms (1400kg)
                    EstimatedPopulationSize = 0, // Information not available in the data
                    AverageLifespanMin = 45,
                    AverageLifespanMax = 50,
                    Diet = "Herbivore",
                    Locations = "2"
                },
                new Animal
                {
                    Id = 30,
                    CommonName = "Indian Rhinoceros",
                    ScientificName = "Rhinoceros Unicornis",
                    AverageHeightMin = 0, // Information not available in the data
                    AverageHeightMax = 0, // Information not available in the data
                    Description = "You can replace this with a description retrieved from the web about Indian Rhinoceros.",  // Description not available in the data
                    AverageSpeedMin = 30,
                    AverageSpeedMax = 30,
                    AverageWeightMin = 4900, // Converted from kilograms (2200kg)
                    AverageWeightMax = 6600, // Converted from kilograms (3000kg)
                    EstimatedPopulationSize = 0, // Information not available in the data
                    AverageLifespanMin = 45,
                    AverageLifespanMax = 50,
                    Diet = "Herbivore",
                    Locations = "1"
                },
                new Animal
                {
                    Id = 31,
                    CommonName = "White Rhinoceros",
                    ScientificName = "Ceratotherium simum",
                    AverageHeightMin = 0, // Information not available in the data
                    AverageHeightMax = 0, // Information not available in the data
                    Description = "You can replace this with a description retrieved from the web about White Rhinoceros.",  // Description not available in the data
                    AverageSpeedMin = 30,
                    AverageSpeedMax = 30,
                    AverageWeightMin = 3168, // Converted from kilograms (1440kg)
                    AverageWeightMax = 7920, // Converted from kilograms (3600kg)
                    EstimatedPopulationSize = 0, // Information not available in the data
                    AverageLifespanMin = 45,
                    AverageLifespanMax = 50,
                    Diet = "Herbivore",
                    Locations = "2"
                },
                new Animal
                {
                    Id = 32,
                    CommonName = "African Bush Elephant",
                    ScientificName = "Loxodonta africana africana",
                    Diet = "Herbivore",
                    AverageWeightMin = 3600,
                    AverageWeightMax = 5400,
                    AverageHeightMin = 300,
                    AverageHeightMax = 350,
                    EstimatedPopulationSize = 300000,
                    Description = "The African Bush Elephant is the largest living land animal.  They have large,扇形 (shàn xíng - fan-shaped) ears to help radiate heat and wrinkled gray skin.  Their tusks are long and curved outwards.  These gentle giants are social creatures living in herds led by females.", // Description retrieved from the web
                    AverageSpeedMin = 25,
                    AverageSpeedMax = 25,
                    AverageLifespanMin = 60,
                    AverageLifespanMax = 70,
                    Locations = "2"
                },
                new Animal
                {
                    Id = 33,
                    CommonName = "African Forest Elephant",
                    ScientificName = "Loxodonta cyclotis",
                    Diet = "Herbivore",
                    AverageWeightMin = 900,
                    AverageWeightMax = 3000,
                    AverageHeightMin = 200,
                    AverageHeightMax = 300,
                    EstimatedPopulationSize = 200000,
                    Description = "The African Forest Elephant is smaller and darker than its savanna relative.  They have characteristically rounded ears and a hairy trunk.  An African forest elephant's tusks are straighter and point downward, rather outwards like savanna elephants.  They play a vital role in seed dispersal by consuming a diet rich in fruits.", // Description retrieved from the web
                    AverageSpeedMin = 24,
                    AverageSpeedMax = 24,
                    AverageLifespanMin = 60,
                    AverageLifespanMax = 70,
                    Locations = "2",
                },
                new Animal
                {
                    Id = 34,
                    CommonName = "Pájaro Azul Oriental",
                    ScientificName = "Sialia sialis",
                    AverageHeightMin = 17, // 17 cm
                    AverageHeightMax = 20, // 20 cm
                    Description = "Un ave cantora pequeña y colorida que habita en bosques abiertos y áreas suburbanas de América del Norte. Se caracteriza por su plumaje azul brillante en los machos y azul más pálido en las hembras.",
                    AverageSpeedMin = 24, // 24 km/h
                    AverageSpeedMax = 32, // 32 km/h
                    AverageWeightMin = 20, // 20 g
                    AverageWeightMax = 30, // 30 g
                    EstimatedPopulationSize = 900000,
                    AverageLifespanMin = 6,
                    AverageLifespanMax = 10,
                    Diet = "Omnívora (fruta favorita)",
                    Locations = "3"
                },
              // Colibrí (general) - Combinar información de Ruby-Throated y Hummingbird
              new Animal
              {
                  Id = 35,
                  CommonName = "Colibrí",
                  ScientificName = "Familia Trochilidae",
                  AverageHeightMin = 5, // 5 cm
                  AverageHeightMax = 10, // 10 cm
                  Description = "Las aves más pequeñas del mundo, conocidas por su vuelo acrobático y su capacidad para alimentarse de néctar. Se encuentran en diversos hábitats de América Central, Norte y Sur.",
                  AverageSpeedMin = 50, // 50 km/h
                  AverageSpeedMax = 90, // 90 km/h
                  AverageWeightMin = 2, // 2 g
                  AverageWeightMax = 6, // 6 g
                  EstimatedPopulationSize = 340, //especies, con poblaciones que varían según la especie,
                  AverageLifespanMin = 3,
                  AverageLifespanMax = 8,
                  Diet = "Nectarívora",
                  Locations = "3;4"
              },
              // Colibrí Rubí Garganta (detalles específicos añadidos al colibrí general)
              new Animal
              {
                  Id = 36,
                  CommonName = "Colibrí Rubí Garganta",
                  ScientificName = "Archilochus colubris",
                  AverageHeightMin = 5, // 5 cm
                  AverageHeightMax = 10, // 10 cm
                  Description = "Un colibrí de tamaño mediano con garganta roja brillante. Habita en bosques, jardines y campos de América del Norte. Construye nidos con telarañas y líquenes.",
                  AverageSpeedMin = 50, // 50 km/h
                  AverageSpeedMax = 90, // 90 km/h
                  AverageWeightMin = 2, // 2 g
                  AverageWeightMax = 6, // 6 g
                  EstimatedPopulationSize = 36000000,
                  AverageLifespanMin = 3,
                  AverageLifespanMax = 8,
                  Diet = "Nectarívora",
                  Locations = "3"
              },
              new Animal
              {
                  Id = 37,
                  CommonName = "Bear",
                  ScientificName = "Ursidae",
                  AverageHeightMin = 48, // 1.2m
                  AverageHeightMax = 129, // 3.3m
                  Description = "Los osos son mamíferos omnívoros de la familia Ursidae, conocidos por su gran tamaño, fuerza y garras afiladas. Habitan en regiones forestales y montañosas de diferentes partes del mundo.",
                  AverageSpeedMin = 20,
                  AverageSpeedMax = 35,
                  AverageWeightMin = 27,
                  AverageWeightMax = 450,
                  EstimatedPopulationSize = 1000000, // Estimación
                  AverageLifespanMin = 15,
                  AverageLifespanMax = 35,
                  Diet = "Omnivore",
                  Locations = "1;6;3;4"
              }
            );
        }
    }
}
