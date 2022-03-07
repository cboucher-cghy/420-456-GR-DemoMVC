using Microsoft.EntityFrameworkCore.Migrations;

namespace Exercice_Form.Migrations
{
    public partial class SeedAjoutPays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "PaysId", "Nom", "Superficie" },
                values: new object[,]
                {
                    { 1, "Afghanistan", 0 },
                    { 153, "Nouvelle-Calédonie", 0 },
                    { 154, "Vanuatu", 0 },
                    { 155, "Nouvelle-Zélande", 0 },
                    { 156, "Nicaragua", 0 },
                    { 157, "Niger", 0 },
                    { 158, "Nigéria", 0 },
                    { 159, "Niué", 0 },
                    { 160, "Île Norfolk", 0 },
                    { 161, "Norvège", 0 },
                    { 162, "Îles Mariannes du Nord", 0 },
                    { 163, "Îles Mineures Éloignées des États-Unis", 0 },
                    { 164, "États Fédérés de Micronésie", 0 },
                    { 152, "Aruba", 0 },
                    { 165, "Îles Marshall", 0 },
                    { 167, "Pakistan", 0 },
                    { 168, "Panama", 0 },
                    { 169, "Papouasie-Nouvelle-Guinée", 0 },
                    { 170, "Paraguay", 0 },
                    { 171, "Pérou", 0 },
                    { 172, "Philippines", 0 },
                    { 173, "Pitcairn", 0 },
                    { 174, "Pologne", 0 },
                    { 175, "Portugal", 0 },
                    { 176, "Guinée-Bissau", 0 },
                    { 177, "Timor-Leste", 0 },
                    { 178, "Porto Rico", 0 },
                    { 166, "Palaos", 0 },
                    { 179, "Qatar", 0 },
                    { 151, "Antilles Néerlandaises", 0 },
                    { 149, "Népal", 0 },
                    { 123, "Lettonie", 0 },
                    { 124, "Libéria", 0 },
                    { 125, "Jamahiriya Arabe Libyenne", 0 },
                    { 126, "Liechtenstein", 0 },
                    { 127, "Lituanie", 0 },
                    { 128, "Luxembourg", 0 },
                    { 129, "Macao", 0 },
                    { 130, "Madagascar", 0 },
                    { 131, "Malawi", 0 },
                    { 132, "Malaisie", 0 },
                    { 133, "Maldives", 0 }
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "PaysId", "Nom", "Superficie" },
                values: new object[,]
                {
                    { 134, "Mali", 0 },
                    { 150, "Pays-Bas", 0 },
                    { 135, "Malte", 0 },
                    { 137, "Mauritanie", 0 },
                    { 138, "Maurice", 0 },
                    { 139, "Mexique", 0 },
                    { 140, "Monaco", 0 },
                    { 141, "Mongolie", 0 },
                    { 142, "République de Moldova", 0 },
                    { 143, "Montserrat", 0 },
                    { 144, "Maroc", 0 },
                    { 145, "Mozambique", 0 },
                    { 146, "Oman", 0 },
                    { 147, "Namibie", 0 },
                    { 148, "Nauru", 0 },
                    { 136, "Martinique", 0 },
                    { 180, "Réunion", 0 },
                    { 181, "Roumanie", 0 },
                    { 182, "Fédération de Russie", 0 },
                    { 214, "Togo", 0 },
                    { 215, "Tokelau", 0 },
                    { 216, "Tonga", 0 },
                    { 217, "Trinité-et-Tobago", 0 },
                    { 218, "Émirats Arabes Unis", 0 },
                    { 219, "Tunisie", 0 },
                    { 220, "Turquie", 0 },
                    { 221, "Turkménistan", 0 },
                    { 222, "Îles Turks et Caïques", 0 },
                    { 223, "Tuvalu", 0 },
                    { 224, "Ouganda", 0 },
                    { 225, "Ukraine", 0 },
                    { 213, "Thaïlande", 0 },
                    { 226, "L'ex-République Yougoslave de Macédoine", 0 },
                    { 228, "Royaume-Uni", 0 },
                    { 229, "Île de Man", 0 },
                    { 230, "République-Unie de Tanzanie", 0 },
                    { 231, "États-Unis", 0 },
                    { 232, "Îles Vierges des États-Unis", 0 },
                    { 233, "Burkina Faso", 0 },
                    { 234, "Uruguay", 0 },
                    { 235, "Ouzbékistan", 0 },
                    { 236, "Venezuela", 0 }
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "PaysId", "Nom", "Superficie" },
                values: new object[,]
                {
                    { 237, "Wallis et Futuna", 0 },
                    { 238, "Samoa", 0 },
                    { 239, "Yémen", 0 },
                    { 227, "Égypte", 0 },
                    { 212, "Tadjikistan", 0 },
                    { 211, "République Arabe Syrienne", 0 },
                    { 210, "Suisse", 0 },
                    { 183, "Rwanda", 0 },
                    { 184, "Sainte-Hélène", 0 },
                    { 185, "Saint-Kitts-et-Nevis", 0 },
                    { 186, "Anguilla", 0 },
                    { 187, "Sainte-Lucie", 0 },
                    { 188, "Saint-Pierre-et-Miquelon", 0 },
                    { 189, "Saint-Vincent-et-les Grenadines", 0 },
                    { 190, "Saint-Marin", 0 },
                    { 191, "Sao Tomé-et-Principe", 0 },
                    { 192, "Arabie Saoudite", 0 },
                    { 193, "Sénégal", 0 },
                    { 194, "Seychelles", 0 },
                    { 195, "Sierra Leone", 0 },
                    { 196, "Singapour", 0 },
                    { 197, "Slovaquie", 0 },
                    { 198, "Viet Nam", 0 },
                    { 199, "Slovénie", 0 },
                    { 200, "Somalie", 0 },
                    { 201, "Afrique du Sud", 0 },
                    { 202, "Zimbabwe", 0 },
                    { 203, "Espagne", 0 },
                    { 204, "Sahara Occidental", 0 },
                    { 205, "Soudan", 0 },
                    { 206, "Suriname", 0 },
                    { 207, "Svalbard etÎle Jan Mayen", 0 },
                    { 208, "Swaziland", 0 },
                    { 209, "Suède", 0 },
                    { 122, "Lesotho", 0 },
                    { 240, "Serbie-et-Monténégro", 0 },
                    { 121, "Liban", 0 },
                    { 119, "Kirghizistan", 0 },
                    { 32, "Myanmar", 0 },
                    { 33, "Burundi", 0 },
                    { 34, "Bélarus", 0 },
                    { 35, "Cambodge", 0 }
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "PaysId", "Nom", "Superficie" },
                values: new object[,]
                {
                    { 36, "Cameroun", 0 },
                    { 37, "Canada", 0 },
                    { 38, "Cap-vert", 0 },
                    { 39, "Îles Caïmanes", 0 },
                    { 40, "République Centrafricaine", 0 },
                    { 41, "Sri Lanka", 0 },
                    { 42, "Tchad", 0 },
                    { 43, "Chili", 0 },
                    { 31, "Bulgarie", 0 },
                    { 44, "Chine", 0 },
                    { 46, "Île Christmas", 0 },
                    { 47, "Îles Cocos (Keeling)", 0 },
                    { 48, "Colombie", 0 },
                    { 49, "Comores", 0 },
                    { 50, "Mayotte", 0 },
                    { 51, "République du Congo", 0 },
                    { 52, "République Démocratique du Congo", 0 },
                    { 53, "Îles Cook", 0 },
                    { 54, "Costa Rica", 0 },
                    { 55, "Croatie", 0 },
                    { 56, "Cuba", 0 },
                    { 57, "Chypre", 0 },
                    { 45, "Taïwan", 0 },
                    { 58, "République Tchèque", 0 },
                    { 30, "Brunéi Darussalam", 0 },
                    { 28, "Îles Salomon", 0 },
                    { 2, "Albanie", 0 },
                    { 3, "Antarctique", 0 },
                    { 4, "Algérie", 0 },
                    { 5, "Samoa Américaines", 0 },
                    { 6, "Andorre", 0 },
                    { 7, "Angola", 0 },
                    { 8, "Antigua-et-Barbuda", 0 },
                    { 9, "Azerbaïdjan", 0 },
                    { 10, "Argentine", 0 },
                    { 11, "Australie", 0 },
                    { 12, "Autriche", 0 },
                    { 13, "Bahamas", 0 },
                    { 29, "Îles Vierges Britanniques", 0 },
                    { 14, "Bahreïn", 0 },
                    { 16, "Arménie", 0 },
                    { 17, "Barbade", 0 }
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "PaysId", "Nom", "Superficie" },
                values: new object[,]
                {
                    { 18, "Belgique", 0 },
                    { 19, "Bermudes", 0 },
                    { 20, "Bhoutan", 0 },
                    { 21, "Bolivie", 0 },
                    { 22, "Bosnie-Herzégovine", 0 },
                    { 23, "Botswana", 0 },
                    { 24, "Île Bouvet", 0 },
                    { 25, "Brésil", 0 },
                    { 26, "Belize", 0 },
                    { 27, "Territoire Britannique de l'Océan Indien", 0 },
                    { 15, "Bangladesh", 0 },
                    { 59, "Bénin", 0 },
                    { 60, "Danemark", 0 },
                    { 61, "Dominique", 0 },
                    { 93, "Guatemala", 0 },
                    { 94, "Guinée", 0 },
                    { 95, "Guyana", 0 },
                    { 96, "Haïti", 0 },
                    { 97, "Îles Heard et Mcdonald", 0 },
                    { 98, "Saint-Siège (état de la Cité du Vatican)", 0 },
                    { 99, "Honduras", 0 },
                    { 100, "Hong-Kong", 0 },
                    { 101, "Hongrie", 0 },
                    { 102, "Islande", 0 },
                    { 103, "Inde", 0 },
                    { 104, "Indonésie", 0 },
                    { 92, "Guam", 0 },
                    { 105, "République Islamique d'Iran", 0 },
                    { 107, "Irlande", 0 },
                    { 108, "Israël", 0 },
                    { 109, "Italie", 0 },
                    { 110, "Côte d'Ivoire", 0 },
                    { 111, "Jamaïque", 0 },
                    { 112, "Japon", 0 },
                    { 113, "Kazakhstan", 0 },
                    { 114, "Jordanie", 0 },
                    { 115, "Kenya", 0 },
                    { 116, "République Populaire Démocratique de Corée", 0 },
                    { 117, "République de Corée", 0 },
                    { 118, "Koweït", 0 },
                    { 106, "Iraq", 0 },
                    { 91, "Guadeloupe", 0 }
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "PaysId", "Nom", "Superficie" },
                values: new object[,]
                {
                    { 90, "Grenade", 0 },
                    { 89, "Groenland", 0 },
                    { 62, "République Dominicaine", 0 },
                    { 63, "Équateur", 0 },
                    { 64, "El Salvador", 0 },
                    { 65, "Guinée Équatoriale", 0 },
                    { 66, "Éthiopie", 0 },
                    { 67, "Érythrée", 0 },
                    { 68, "Estonie", 0 },
                    { 69, "Îles Féroé", 0 },
                    { 70, "Îles (malvinas) Falkland", 0 },
                    { 71, "Géorgie du Sud et les Îles Sandwich du Sud", 0 },
                    { 72, "Fidji", 0 },
                    { 73, "Finlande", 0 },
                    { 74, "Îles Åland", 0 },
                    { 75, "France", 0 },
                    { 76, "Guyane Française", 0 },
                    { 77, "Polynésie Française", 0 },
                    { 78, "Terres Australes Françaises", 0 },
                    { 79, "Djibouti", 0 },
                    { 80, "Gabon", 0 },
                    { 81, "Géorgie", 0 },
                    { 82, "Gambie", 0 },
                    { 83, "Territoire Palestinien Occupé", 0 },
                    { 84, "Allemagne", 0 },
                    { 85, "Ghana", 0 },
                    { 86, "Gibraltar", 0 },
                    { 87, "Kiribati", 0 },
                    { 88, "Grèce", 0 },
                    { 120, "République Démocratique Populaire Lao", 0 },
                    { 241, "Zambie", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Pays",
                keyColumn: "PaysId",
                keyValue: 241);
        }
    }
}
