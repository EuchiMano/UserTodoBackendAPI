﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Completed", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, false, "delectus aut autem", 1 },
                    { 2, false, "quis ut nam facilis et officia qui", 1 },
                    { 3, false, "fugiat veniam minus", 1 },
                    { 4, true, "et porro tempora", 1 },
                    { 5, false, "laboriosam mollitia et enim quasi adipisci quia provident illum", 1 },
                    { 6, false, "qui ullam ratione quibusdam voluptatem quia omnis", 1 },
                    { 7, false, "illo expedita consequatur quia in", 1 },
                    { 8, true, "quo adipisci enim quam ut ab", 1 },
                    { 9, false, "molestiae perspiciatis ipsa", 1 },
                    { 10, true, "illo est ratione doloremque quia maiores aut", 1 },
                    { 11, true, "vero rerum temporibus dolor", 1 },
                    { 12, true, "ipsa repellendus fugit nisi", 1 },
                    { 13, false, "et doloremque nulla", 1 },
                    { 14, true, "repellendus sunt dolores architecto voluptatum", 1 },
                    { 15, true, "ab voluptatum amet voluptas", 1 },
                    { 16, true, "accusamus eos facilis sint et aut voluptatem", 1 },
                    { 17, true, "quo laboriosam deleniti aut qui", 1 },
                    { 18, false, "dolorum est consequatur ea mollitia in culpa", 1 },
                    { 19, true, "molestiae ipsa aut voluptatibus pariatur dolor nihil", 1 },
                    { 20, true, "ullam nobis libero sapiente ad optio sint", 1 },
                    { 21, false, "suscipit repellat esse quibusdam voluptatem incidunt", 2 },
                    { 22, true, "distinctio vitae autem nihil ut molestias quo", 2 },
                    { 23, false, "et itaque necessitatibus maxime molestiae qui quas velit", 2 },
                    { 24, false, "adipisci non ad dicta qui amet quaerat doloribus ea", 2 },
                    { 25, true, "voluptas quo tenetur perspiciatis explicabo natus", 2 },
                    { 26, true, "aliquam aut quasi", 2 },
                    { 27, true, "veritatis pariatur delectus", 2 },
                    { 28, false, "nesciunt totam sit blanditiis sit", 2 },
                    { 29, false, "laborum aut in quam", 2 },
                    { 30, true, "nemo perspiciatis repellat ut dolor libero commodi blanditiis omnis", 2 },
                    { 31, false, "repudiandae totam in est sint facere fuga", 2 },
                    { 32, false, "earum doloribus ea doloremque quis", 2 },
                    { 33, false, "sint sit aut vero", 2 },
                    { 34, false, "porro aut necessitatibus eaque distinctio", 2 },
                    { 35, true, "repellendus veritatis molestias dicta incidunt", 2 },
                    { 36, true, "excepturi deleniti adipisci voluptatem et neque optio illum ad", 2 },
                    { 37, false, "sunt cum tempora", 2 },
                    { 38, false, "totam quia non", 2 },
                    { 39, false, "doloremque quibusdam asperiores libero corrupti illum qui omnis", 2 },
                    { 40, true, "totam atque quo nesciunt", 2 },
                    { 41, false, "aliquid amet impedit consequatur aspernatur placeat eaque fugiat suscipit", 3 },
                    { 42, false, "rerum perferendis error quia ut eveniet", 3 },
                    { 43, true, "tempore ut sint quis recusandae", 3 },
                    { 44, true, "cum debitis quis accusamus doloremque ipsa natus sapiente omnis", 3 },
                    { 45, false, "velit soluta adipisci molestias reiciendis harum", 3 },
                    { 46, false, "vel voluptatem repellat nihil placeat corporis", 3 },
                    { 47, false, "nam qui rerum fugiat accusamus", 3 },
                    { 48, false, "sit reprehenderit omnis quia", 3 },
                    { 49, false, "ut necessitatibus aut maiores debitis officia blanditiis velit et", 3 },
                    { 50, true, "cupiditate necessitatibus ullam aut quis dolor voluptate", 3 },
                    { 51, false, "distinctio exercitationem ab doloribus", 3 },
                    { 52, false, "nesciunt dolorum quis recusandae ad pariatur ratione", 3 },
                    { 53, false, "qui labore est occaecati recusandae aliquid quam", 3 },
                    { 54, true, "quis et est ut voluptate quam dolor", 3 },
                    { 55, true, "voluptatum omnis minima qui occaecati provident nulla voluptatem ratione", 3 },
                    { 56, true, "deleniti ea temporibus enim", 3 },
                    { 57, false, "pariatur et magnam ea doloribus similique voluptatem rerum quia", 3 },
                    { 58, false, "est dicta totam qui explicabo doloribus qui dignissimos", 3 },
                    { 59, false, "perspiciatis velit id laborum placeat iusto et aliquam odio", 3 },
                    { 60, true, "et sequi qui architecto ut adipisci", 3 },
                    { 61, true, "odit optio omnis qui sunt", 4 },
                    { 62, false, "et placeat et tempore aspernatur sint numquam", 4 },
                    { 63, true, "doloremque aut dolores quidem fuga qui nulla", 4 },
                    { 64, false, "voluptas consequatur qui ut quia magnam nemo esse", 4 },
                    { 65, false, "fugiat pariatur ratione ut asperiores necessitatibus magni", 4 },
                    { 66, false, "rerum eum molestias autem voluptatum sit optio", 4 },
                    { 67, false, "quia voluptatibus voluptatem quos similique maiores repellat", 4 },
                    { 68, false, "aut id perspiciatis voluptatem iusto", 4 },
                    { 69, false, "doloribus sint dolorum ab adipisci itaque dignissimos aliquam suscipit", 4 },
                    { 70, false, "ut sequi accusantium et mollitia delectus sunt", 4 },
                    { 71, false, "aut velit saepe ullam", 4 },
                    { 72, false, "praesentium facilis facere quis harum voluptatibus voluptatem eum", 4 },
                    { 73, true, "sint amet quia totam corporis qui exercitationem commodi", 4 },
                    { 74, false, "expedita tempore nobis eveniet laborum maiores", 4 },
                    { 75, false, "occaecati adipisci est possimus totam", 4 },
                    { 76, true, "sequi dolorem sed", 4 },
                    { 77, false, "maiores aut nesciunt delectus exercitationem vel assumenda eligendi at", 4 },
                    { 78, false, "reiciendis est magnam amet nemo iste recusandae impedit quaerat", 4 },
                    { 79, true, "eum ipsa maxime ut", 4 },
                    { 80, true, "tempore molestias dolores rerum sequi voluptates ipsum consequatur", 4 },
                    { 81, true, "suscipit qui totam", 5 },
                    { 82, false, "voluptates eum voluptas et dicta", 5 },
                    { 83, true, "quidem at rerum quis ex aut sit quam", 5 },
                    { 84, false, "sunt veritatis ut voluptate", 5 },
                    { 85, true, "et quia ad iste a", 5 },
                    { 86, true, "incidunt ut saepe autem", 5 },
                    { 87, true, "laudantium quae eligendi consequatur quia et vero autem", 5 },
                    { 88, false, "vitae aut excepturi laboriosam sint aliquam et et accusantium", 5 },
                    { 89, true, "sequi ut omnis et", 5 },
                    { 90, true, "molestiae nisi accusantium tenetur dolorem et", 5 },
                    { 91, true, "nulla quis consequatur saepe qui id expedita", 5 },
                    { 92, true, "in omnis laboriosam", 5 },
                    { 93, true, "odio iure consequatur molestiae quibusdam necessitatibus quia sint", 5 },
                    { 94, false, "facilis modi saepe mollitia", 5 },
                    { 95, true, "vel nihil et molestiae iusto assumenda nemo quo ut", 5 },
                    { 96, false, "nobis suscipit ducimus enim asperiores voluptas", 5 },
                    { 97, false, "dolorum laboriosam eos qui iure aliquam", 5 },
                    { 98, true, "debitis accusantium ut quo facilis nihil quis sapiente necessitatibus", 5 },
                    { 99, false, "neque voluptates ratione", 5 },
                    { 100, false, "excepturi a et neque qui expedita vel voluptate", 5 },
                    { 101, false, "explicabo enim cumque porro aperiam occaecati minima", 6 },
                    { 102, false, "sed ab consequatur", 6 },
                    { 103, false, "non sunt delectus illo nulla tenetur enim omnis", 6 },
                    { 104, false, "excepturi non laudantium quo", 6 },
                    { 105, true, "totam quia dolorem et illum repellat voluptas optio", 6 },
                    { 106, true, "ad illo quis voluptatem temporibus", 6 },
                    { 107, false, "praesentium facilis omnis laudantium fugit ad iusto nihil nesciunt", 6 },
                    { 108, true, "a eos eaque nihil et exercitationem incidunt delectus", 6 },
                    { 109, true, "autem temporibus harum quisquam in culpa", 6 },
                    { 110, true, "aut aut ea corporis", 6 },
                    { 111, false, "magni accusantium labore et id quis provident", 6 },
                    { 112, false, "consectetur impedit quisquam qui deserunt non rerum consequuntur eius", 6 },
                    { 113, false, "quia atque aliquam sunt impedit voluptatum rerum assumenda nisi", 6 },
                    { 114, false, "cupiditate quos possimus corporis quisquam exercitationem beatae", 6 },
                    { 115, false, "sed et ea eum", 6 },
                    { 116, true, "ipsa dolores vel facilis ut", 6 },
                    { 117, false, "sequi quae est et qui qui eveniet asperiores", 6 },
                    { 118, false, "quia modi consequatur vero fugiat", 6 },
                    { 119, false, "corporis ducimus ea perspiciatis iste", 6 },
                    { 120, false, "dolorem laboriosam vel voluptas et aliquam quasi", 6 },
                    { 121, true, "inventore aut nihil minima laudantium hic qui omnis", 7 },
                    { 122, true, "provident aut nobis culpa", 7 },
                    { 123, false, "esse et quis iste est earum aut impedit", 7 },
                    { 124, false, "qui consectetur id", 7 },
                    { 125, false, "aut quasi autem iste tempore illum possimus", 7 },
                    { 126, true, "ut asperiores perspiciatis veniam ipsum rerum saepe", 7 },
                    { 127, true, "voluptatem libero consectetur rerum ut", 7 },
                    { 128, false, "eius omnis est qui voluptatem autem", 7 },
                    { 129, false, "rerum culpa quis harum", 7 },
                    { 130, true, "nulla aliquid eveniet harum laborum libero alias ut unde", 7 },
                    { 131, false, "qui ea incidunt quis", 7 },
                    { 132, true, "qui molestiae voluptatibus velit iure harum quisquam", 7 },
                    { 133, true, "et labore eos enim rerum consequatur sunt", 7 },
                    { 134, false, "molestiae doloribus et laborum quod ea", 7 },
                    { 135, false, "facere ipsa nam eum voluptates reiciendis vero qui", 7 },
                    { 136, false, "asperiores illo tempora fuga sed ut quasi adipisci", 7 },
                    { 137, false, "qui sit non", 7 },
                    { 138, true, "placeat minima consequatur rem qui ut", 7 },
                    { 139, false, "consequatur doloribus id possimus voluptas a voluptatem", 7 },
                    { 140, true, "aut consectetur in blanditiis deserunt quia sed laboriosam", 7 },
                    { 141, true, "explicabo consectetur debitis voluptates quas quae culpa rerum non", 8 },
                    { 142, true, "maiores accusantium architecto necessitatibus reiciendis ea aut", 8 },
                    { 143, false, "eum non recusandae cupiditate animi", 8 },
                    { 144, false, "ut eum exercitationem sint", 8 },
                    { 145, false, "beatae qui ullam incidunt voluptatem non nisi aliquam", 8 },
                    { 146, true, "molestiae suscipit ratione nihil odio libero impedit vero totam", 8 },
                    { 147, true, "eum itaque quod reprehenderit et facilis dolor autem ut", 8 },
                    { 148, false, "esse quas et quo quasi exercitationem", 8 },
                    { 149, false, "animi voluptas quod perferendis est", 8 },
                    { 150, false, "eos amet tempore laudantium fugit a", 8 },
                    { 151, true, "accusamus adipisci dicta qui quo ea explicabo sed vero", 8 },
                    { 152, false, "odit eligendi recusandae doloremque cumque non", 8 },
                    { 153, false, "ea aperiam consequatur qui repellat eos", 8 },
                    { 154, true, "rerum non ex sapiente", 8 },
                    { 155, true, "voluptatem nobis consequatur et assumenda magnam", 8 },
                    { 156, true, "nam quia quia nulla repellat assumenda quibusdam sit nobis", 8 },
                    { 157, true, "dolorem veniam quisquam deserunt repellendus", 8 },
                    { 158, true, "debitis vitae delectus et harum accusamus aut deleniti a", 8 },
                    { 159, true, "debitis adipisci quibusdam aliquam sed dolore ea praesentium nobis", 8 },
                    { 160, false, "et praesentium aliquam est", 8 },
                    { 161, true, "ex hic consequuntur earum omnis alias ut occaecati culpa", 9 },
                    { 162, true, "omnis laboriosam molestias animi sunt dolore", 9 },
                    { 163, false, "natus corrupti maxime laudantium et voluptatem laboriosam odit", 9 },
                    { 164, false, "reprehenderit quos aut aut consequatur est sed", 9 },
                    { 165, false, "fugiat perferendis sed aut quidem", 9 },
                    { 166, false, "quos quo possimus suscipit minima ut", 9 },
                    { 167, false, "et quis minus quo a asperiores molestiae", 9 },
                    { 168, false, "recusandae quia qui sunt libero", 9 },
                    { 169, true, "ea odio perferendis officiis", 9 },
                    { 170, false, "quisquam aliquam quia doloribus aut", 9 },
                    { 171, true, "fugiat aut voluptatibus corrupti deleniti velit iste odio", 9 },
                    { 172, false, "et provident amet rerum consectetur et voluptatum", 9 },
                    { 173, false, "harum ad aperiam quis", 9 },
                    { 174, false, "similique aut quo", 9 },
                    { 175, true, "laudantium eius officia perferendis provident perspiciatis asperiores", 9 },
                    { 176, false, "magni soluta corrupti ut maiores rem quidem", 9 },
                    { 177, false, "et placeat temporibus voluptas est tempora quos quibusdam", 9 },
                    { 178, true, "nesciunt itaque commodi tempore", 9 },
                    { 179, true, "omnis consequuntur cupiditate impedit itaque ipsam quo", 9 },
                    { 180, true, "debitis nisi et dolorem repellat et", 9 },
                    { 181, false, "ut cupiditate sequi aliquam fuga maiores", 10 },
                    { 182, true, "inventore saepe cumque et aut illum enim", 10 },
                    { 183, true, "omnis nulla eum aliquam distinctio", 10 },
                    { 184, false, "molestias modi perferendis perspiciatis", 10 },
                    { 185, false, "voluptates dignissimos sed doloribus animi quaerat aut", 10 },
                    { 186, false, "explicabo odio est et", 10 },
                    { 187, false, "consequuntur animi possimus", 10 },
                    { 188, true, "vel non beatae est", 10 },
                    { 189, true, "culpa eius et voluptatem et", 10 },
                    { 190, true, "accusamus sint iusto et voluptatem exercitationem", 10 },
                    { 191, true, "temporibus atque distinctio omnis eius impedit tempore molestias pariatur", 10 },
                    { 192, false, "ut quas possimus exercitationem sint voluptates", 10 },
                    { 193, true, "rerum debitis voluptatem qui eveniet tempora distinctio a", 10 },
                    { 194, false, "sed ut vero sit molestiae", 10 },
                    { 195, true, "rerum ex veniam mollitia voluptatibus pariatur", 10 },
                    { 196, true, "consequuntur aut ut fugit similique", 10 },
                    { 197, true, "dignissimos quo nobis earum saepe", 10 },
                    { 198, true, "quis eius est sint explicabo", 10 },
                    { 199, true, "numquam repellendus a magnam", 10 },
                    { 200, false, "ipsam aperiam voluptates qui", 10 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Username", "Website" },
                values: new object[,]
                {
                    { 1, "Sincere@april.biz", "Leanne Graham", "asd123", "Bret", "hildegard.org" },
                    { 2, "Shanna@melissa.tv", "Ervin Howell", "asd123", "Antonette", "anastasia.net" },
                    { 3, "Nathan@yesenia.net", "Clementine Bauch", "asd123", "Samantha", "ramiro.info" },
                    { 4, "Julianne.OConner@kory.org", "Patricia Lebsack", "asd123", "Karianne", "kale.biz" },
                    { 5, "Lucio_Hettinger@annie.ca", "Chelsey Dietrich", "asd123", "Kamren", "demarco.info" },
                    { 6, "Karley_Dach@jasper.info", "Mrs. Dennis Schulist", "asd123", "Leopoldo_Corkery", "ola.org" },
                    { 7, "Telly.Hoeger@billy.biz", "Kurtis Weissnat", "asd123", "Elwyn.Skiles", "elvis.io" },
                    { 8, "Sherwood@rosamond.me", "Nicholas Runolfsdottir V", "asd123", "Maxime_Nienow", "jacynthe.com" },
                    { 9, "Chaim_McDermott@dana.io", "Glenna Reichert", "asd123", "Delphine", "conrad.com" },
                    { 10, "Rey.Padberg@karina.biz", "Clementina DuBuque", "asd123", "Moriah.Stanton", "ambrose.net" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
