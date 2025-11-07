using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint1.Migrations
{
    /// <inheritdoc />
    public partial class FIAP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    PRODUTO_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TITULO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DESCRICAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IMAGEM_URL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PRECO_ORIGINAL = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PRECO_DESCONTADO = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    ESTOQUE = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PESO = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    DIMENSOES = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CONDICAO_PRODUTO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CATEGORIA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IDIOMA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AVALIACAO_MEDIA = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    NUMERO_DE_AVALIACOES = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.PRODUTO_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUTOS");
        }
    }
}
