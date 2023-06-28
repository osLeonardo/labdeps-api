using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PortalTransparenciaDeps.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agrupador_parametrizacao",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_agrupadores_parametrizacao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dados",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cnpj = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    cnpj_matriz = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    tipo_unidade = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    razao_social = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    nome_fantasia = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    situacao_cadastral = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    data_situacao_cadastral = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    motivo_situacao_cadastral = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    nome_cidade_exterior = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    nome_pais = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    natureza_juridica = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    data_inicio_atividade = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    data_inicio_atividade_matriz = table.Column<string>(type: "text", nullable: true),
                    cnae_principal = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    descricao_tipo_logradouro = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    logradouro = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    numero = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    complemento = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    bairro = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    cep = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    uf = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    municipio = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    municipio_codigo_ibge = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    telefone01 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    telefone02 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    fax = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    correio_eletronico = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    qualificacao_responsavel = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    capital_social_empresa = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    porte = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    opcao_pelo_simples = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    data_opcao_pelo_simples = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    data_exclusao_opcao_pelo_simples = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    opcao_mei = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    situacao_especial = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    data_situacao_especial = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    nome_ente_federativo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_dados", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perfil",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ativo = table.Column<bool>(type: "boolean", nullable: false),
                    ordem = table.Column<int>(type: "integer", nullable: false, defaultValue: 999999)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfis", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "socio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    documento = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    qualificacao = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    id_dado = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_socios", x => x.id);
                    table.ForeignKey(
                        name: "fk_socios_dados_id_dado",
                        column: x => x.id_dado,
                        principalTable: "dados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "perfil_metrica",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    metrica_id = table.Column<int>(type: "integer", nullable: false),
                    pontuacao_maxima = table.Column<decimal>(type: "numeric", nullable: false),
                    pontuacao_minima = table.Column<decimal>(type: "numeric", nullable: false),
                    validade = table.Column<int>(type: "integer", nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfis_metricas", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfis_metricas_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_login",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    login = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    password = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    perfil_usuario = table.Column<int>(type: "integer", nullable: false, defaultValue: 4),
                    id_perfil = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_logins", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_logins_perfis_id_perfil",
                        column: x => x.id_perfil,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "parametrizacao_metrica",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    perfil_metrica_id = table.Column<int>(type: "integer", nullable: false),
                    agrupador_parametrizacao_id = table.Column<Guid>(type: "uuid", nullable: false),
                    descricao = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    idade = table.Column<int>(type: "integer", nullable: true),
                    valor = table.Column<decimal>(type: "numeric", nullable: true),
                    quantidade = table.Column<int>(type: "integer", nullable: true),
                    impacto = table.Column<decimal>(type: "numeric", nullable: true),
                    pontualidade = table.Column<decimal>(type: "numeric", nullable: true),
                    pontuacao = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parametrizacao_metricas", x => x.id);
                    table.ForeignKey(
                        name: "fk_parametrizacao_metricas_agrupador_parametrizacao_agrupador_pa~",
                        column: x => x.agrupador_parametrizacao_id,
                        principalTable: "agrupador_parametrizacao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_parametrizacao_metricas_perfis_metricas_perfil_metrica_id",
                        column: x => x.perfil_metrica_id,
                        principalTable: "perfil_metrica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historico_consulta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    data_consulta = table.Column<DateOnly>(type: "date", nullable: false),
                    tipo_consulta = table.Column<string>(type: "text", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    data_referencia = table.Column<DateOnly>(type: "date", nullable: false),
                    intervalo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_historico_consultas", x => x.id);
                    table.ForeignKey(
                        name: "fk_historico_consultas_user_logins_user_id",
                        column: x => x.user_id,
                        principalTable: "user_login",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_historico_consulta_user_id",
                table: "historico_consulta",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_parametrizacao_metrica_agrupador_parametrizacao_id",
                table: "parametrizacao_metrica",
                column: "agrupador_parametrizacao_id");

            migrationBuilder.CreateIndex(
                name: "IX_parametrizacao_metrica_perfil_metrica_id",
                table: "parametrizacao_metrica",
                column: "perfil_metrica_id");

            migrationBuilder.CreateIndex(
                name: "IX_perfil_metrica_metrica_id_perfil_id",
                table: "perfil_metrica",
                columns: new[] { "metrica_id", "perfil_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_perfil_metrica_perfil_id",
                table: "perfil_metrica",
                column: "perfil_id");

            migrationBuilder.CreateIndex(
                name: "IX_socio_id_dado",
                table: "socio",
                column: "id_dado");

            migrationBuilder.CreateIndex(
                name: "IX_user_login_id_perfil",
                table: "user_login",
                column: "id_perfil");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historico_consulta");

            migrationBuilder.DropTable(
                name: "parametrizacao_metrica");

            migrationBuilder.DropTable(
                name: "socio");

            migrationBuilder.DropTable(
                name: "user_login");

            migrationBuilder.DropTable(
                name: "agrupador_parametrizacao");

            migrationBuilder.DropTable(
                name: "perfil_metrica");

            migrationBuilder.DropTable(
                name: "dados");

            migrationBuilder.DropTable(
                name: "perfil");
        }
    }
}
