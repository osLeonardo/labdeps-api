using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PortalTransparenciaDeps.Infrastructure.Migrations
{
    public partial class portalTransparenciaDB_migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "beneficiario_bpc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cpf_formatado = table.Column<string>(type: "text", nullable: false),
                    cpf_representante_legal_formatado = table.Column<string>(type: "text", nullable: false),
                    nis = table.Column<string>(type: "text", nullable: false),
                    nis_representante_legal = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false),
                    nome_represntante_legal = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_beneficiario_bpc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "beneficiario_peti",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cpf_formatado = table.Column<string>(type: "text", nullable: false),
                    nis = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_beneficiario_peti", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "convenio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    numero = table.Column<string>(type: "text", nullable: false),
                    objeto = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_convenio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "estado_exercicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    sigla = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_estado_exercicio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fonte_sancao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    endereco_contato = table.Column<string>(type: "text", nullable: false),
                    nome_exibicao = table.Column<string>(type: "text", nullable: false),
                    telefone_contato = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_fonte_sancao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "funcao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo_funcao_cargo = table.Column<string>(type: "text", nullable: false),
                    descricao_funcao_cargo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_funcao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "leniencia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_fim_acordo = table.Column<string>(type: "text", nullable: false),
                    data_inicio_acordo = table.Column<string>(type: "text", nullable: false),
                    orgao_responsavel = table.Column<string>(type: "text", nullable: false),
                    quantidade = table.Column<int>(type: "integer", nullable: false),
                    situacao_acordo = table.Column<string>(type: "text", nullable: false),
                    id_sancoes = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_leniencia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orgao_maximo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false),
                    sigla = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orgao_maximo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orgao_sancionador",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    poder = table.Column<string>(type: "text", nullable: false),
                    sigla_uf = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orgao_sancionador", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orgao_servidor_exercicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    codigo_orgao_vinculado = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false),
                    nome_orgao_vinculado = table.Column<string>(type: "text", nullable: false),
                    sigla = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orgao_servidor_exercicio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orgao_servidor_lotacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    codigo_orgao_vinculado = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false),
                    nome_orgao_vinculado = table.Column<string>(type: "text", nullable: false),
                    sigla = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orgao_servidor_lotacao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pensionista_representante",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cpf_formatado = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pensionista_representante", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pep",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cod_orgao = table.Column<string>(type: "text", nullable: false),
                    cpf = table.Column<string>(type: "text", nullable: false),
                    descricao_funcao = table.Column<string>(type: "text", nullable: false),
                    dt_fim_carencia = table.Column<string>(type: "text", nullable: false),
                    dt_fim_exercicio = table.Column<string>(type: "text", nullable: false),
                    dt_inicio_exercicio = table.Column<string>(type: "text", nullable: false),
                    nivel_funcao = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false),
                    nome_orgao = table.Column<string>(type: "text", nullable: false),
                    sigla_funcao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pep", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pessoa_juridica",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cnpj_formatado = table.Column<string>(type: "text", nullable: false),
                    cpf_formatado = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false),
                    nome_fantasia_receita = table.Column<string>(type: "text", nullable: false),
                    numero_inscricao_social = table.Column<string>(type: "text", nullable: false),
                    razao_social = table.Column<string>(type: "text", nullable: false),
                    tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pessoa_juridica", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sancionado",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo_formatado = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sancionado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "servidor_inativo_instuidor_pensao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cpf_formatado = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_servidor_inativo_instuidor_pensao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_sancao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao_portal = table.Column<string>(type: "text", nullable: false),
                    descricao_resumida = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tipo_sancao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "titular_bolsa_familia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cpf_formatado = table.Column<string>(type: "text", nullable: false),
                    nis = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_titular_bolsa_familia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "uf",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    sigla = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_uf", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sancoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cnpj = table.Column<string>(type: "text", nullable: false),
                    cnpj_formatado = table.Column<string>(type: "text", nullable: false),
                    nome_fantasia = table.Column<string>(type: "text", nullable: false),
                    nome_informado_orgao_responsavel = table.Column<string>(type: "text", nullable: false),
                    razao_social = table.Column<string>(type: "text", nullable: false),
                    id_leniencia = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sancoes", x => x.id);
                    table.ForeignKey(
                        name: "fk_sancoes_leniencia_id_leniencia",
                        column: x => x.id_leniencia,
                        principalTable: "leniencia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orgao_superior",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cnpj = table.Column<string>(type: "text", nullable: false),
                    codigo_siafi = table.Column<string>(type: "text", nullable: false),
                    descricao_poder = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false),
                    sigla = table.Column<string>(type: "text", nullable: false),
                    id_orgao_maximo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orgao_superior", x => x.id);
                    table.ForeignKey(
                        name: "fk_orgao_superior_orgao_maximo_id_orgao_maximo",
                        column: x => x.id_orgao_maximo,
                        principalTable: "orgao_maximo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "servidor",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo_matricula_formatado = table.Column<string>(type: "text", nullable: false),
                    flag_afastado = table.Column<int>(type: "integer", nullable: false),
                    id_servidor_aposentado_pensionista = table.Column<int>(type: "integer", nullable: false),
                    situacao = table.Column<string>(type: "text", nullable: false),
                    tipo_servidor = table.Column<string>(type: "text", nullable: false),
                    id_estado_exercicio = table.Column<int>(type: "integer", nullable: false),
                    id_funcao = table.Column<int>(type: "integer", nullable: false),
                    id_orgao_servidor_exercicio = table.Column<int>(type: "integer", nullable: false),
                    id_orgao_servidor_lotacao = table.Column<int>(type: "integer", nullable: false),
                    id_pensionista_representante = table.Column<int>(type: "integer", nullable: false),
                    id_pessoa_juridica = table.Column<int>(type: "integer", nullable: false),
                    id_servidor_inativo_instuidor_pensao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_servidor", x => x.id);
                    table.ForeignKey(
                        name: "fk_servidor_estado_exercicio_id_estado_exercicio",
                        column: x => x.id_estado_exercicio,
                        principalTable: "estado_exercicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_servidor_funcao_id_funcao",
                        column: x => x.id_funcao,
                        principalTable: "funcao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_servidor_orgao_servidor_exercicio_id_orgao_servidor_exercicio",
                        column: x => x.id_orgao_servidor_exercicio,
                        principalTable: "orgao_servidor_exercicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_servidor_orgao_servidor_lotacao_id_orgao_servidor_lotacao",
                        column: x => x.id_orgao_servidor_lotacao,
                        principalTable: "orgao_servidor_lotacao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_servidor_pensionista_representante_id_pensionista_representan~",
                        column: x => x.id_pensionista_representante,
                        principalTable: "pensionista_representante",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_servidor_pessoa_juridica_id_pessoa_juridica",
                        column: x => x.id_pessoa_juridica,
                        principalTable: "pessoa_juridica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_servidor_servidor_inativo_instuidor_pensao_id_servidor_inativo_in~",
                        column: x => x.id_servidor_inativo_instuidor_pensao,
                        principalTable: "servidor_inativo_instuidor_pensao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cnep",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    abrangencia_definida_decisao_judicial = table.Column<string>(type: "text", nullable: false),
                    data_fim_sancao = table.Column<string>(type: "text", nullable: false),
                    data_inicio_sancao = table.Column<string>(type: "text", nullable: false),
                    data_origem_informacao = table.Column<string>(type: "text", nullable: false),
                    data_publicacao_sancao = table.Column<string>(type: "text", nullable: false),
                    data_referencia = table.Column<string>(type: "text", nullable: false),
                    data_transitado_julgado = table.Column<string>(type: "text", nullable: false),
                    detalhamento_publicacao = table.Column<string>(type: "text", nullable: false),
                    informacoes_adicionais_do_orgao_sancionador = table.Column<string>(type: "text", nullable: false),
                    link_publicacao = table.Column<string>(type: "text", nullable: false),
                    numero_processo = table.Column<string>(type: "text", nullable: false),
                    texto_publicacao = table.Column<string>(type: "text", nullable: false),
                    valor_multa = table.Column<string>(type: "text", nullable: false),
                    id_fundamentacao = table.Column<int>(type: "integer", nullable: false),
                    id_fonte_sancao = table.Column<int>(type: "integer", nullable: false),
                    id_pessoa_juridica = table.Column<int>(type: "integer", nullable: false),
                    id_sancionado = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_sancao = table.Column<int>(type: "integer", nullable: false),
                    orgao_sancionador_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cnep", x => x.id);
                    table.ForeignKey(
                        name: "fk_cnep_fonte_sancao_id_fonte_sancao",
                        column: x => x.id_fonte_sancao,
                        principalTable: "fonte_sancao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cnep_orgao_sancionador_orgao_sancionador_id",
                        column: x => x.orgao_sancionador_id,
                        principalTable: "orgao_sancionador",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_cnep_pessoa_juridica_id_pessoa_juridica",
                        column: x => x.id_pessoa_juridica,
                        principalTable: "pessoa_juridica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cnep_sancionado_id_sancionado",
                        column: x => x.id_sancionado,
                        principalTable: "sancionado",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cnep_tipo_sancao_id_tipo_sancao",
                        column: x => x.id_tipo_sancao,
                        principalTable: "tipo_sancao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "municipio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo_ibge = table.Column<string>(type: "text", nullable: false),
                    codigo_regiao = table.Column<string>(type: "text", nullable: false),
                    nome_ibge = table.Column<string>(type: "text", nullable: false),
                    nome_regiao = table.Column<string>(type: "text", nullable: false),
                    pais = table.Column<string>(type: "text", nullable: false),
                    id_uf = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_municipio", x => x.id);
                    table.ForeignKey(
                        name: "fk_municipio_uf_id_uf",
                        column: x => x.id_uf,
                        principalTable: "uf",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "leniencia_sancoes",
                columns: table => new
                {
                    leniencias_id = table.Column<int>(type: "integer", nullable: false),
                    sancoes_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_leniencia_sancoes", x => new { x.leniencias_id, x.sancoes_id });
                    table.ForeignKey(
                        name: "fk_leniencia_sancoes_leniencia_leniencias_id",
                        column: x => x.leniencias_id,
                        principalTable: "leniencia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_leniencia_sancoes_sancoes_sancoes_id",
                        column: x => x.sancoes_id,
                        principalTable: "sancoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cepim",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_referencia = table.Column<string>(type: "text", nullable: false),
                    motivo = table.Column<string>(type: "text", nullable: false),
                    id_convenio = table.Column<int>(type: "integer", nullable: false),
                    id_orgao_superior = table.Column<int>(type: "integer", nullable: false),
                    id_pessoa_juridica = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cepim", x => x.id);
                    table.ForeignKey(
                        name: "fk_cepim_convenio_id_convenio",
                        column: x => x.id_convenio,
                        principalTable: "convenio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cepim_orgao_superior_id_orgao_superior",
                        column: x => x.id_orgao_superior,
                        principalTable: "orgao_superior",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cepim_pessoa_juridica_id_pessoa_juridica",
                        column: x => x.id_pessoa_juridica,
                        principalTable: "pessoa_juridica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "remuneracao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_servidor = table.Column<int>(type: "integer", nullable: false),
                    id_remuneracoes_dto = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_remuneracao", x => x.id);
                    table.ForeignKey(
                        name: "fk_remuneracao_servidor_id_servidor",
                        column: x => x.id_servidor,
                        principalTable: "servidor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "fundamentacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    id_cnep = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_fundamentacao", x => x.id);
                    table.ForeignKey(
                        name: "fk_fundamentacao_cnep_id_cnep",
                        column: x => x.id_cnep,
                        principalTable: "cnep",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bolsa_familia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_mes_competencia = table.Column<string>(type: "text", nullable: false),
                    data_mes_referencia = table.Column<string>(type: "text", nullable: false),
                    quantidade_dependentes = table.Column<int>(type: "integer", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    id_municipio = table.Column<int>(type: "integer", nullable: false),
                    id_titular = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_bolsa_familia", x => x.id);
                    table.ForeignKey(
                        name: "fk_bolsa_familia_municipio_id_municipio",
                        column: x => x.id_municipio,
                        principalTable: "municipio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_bolsa_familia_titular_bolsa_familia_id_titular",
                        column: x => x.id_titular,
                        principalTable: "titular_bolsa_familia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bpc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    concedido_judicialmente = table.Column<bool>(type: "boolean", nullable: false),
                    data_mes_competencia = table.Column<string>(type: "text", nullable: false),
                    data_mes_referencia = table.Column<string>(type: "text", nullable: false),
                    menor16_anos = table.Column<bool>(type: "boolean", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    id_municipio = table.Column<int>(type: "integer", nullable: false),
                    id_beneficiario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_bpc", x => x.id);
                    table.ForeignKey(
                        name: "fk_bpc_beneficiario_bpc_id_beneficiario",
                        column: x => x.id_beneficiario,
                        principalTable: "beneficiario_bpc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_bpc_municipio_id_municipio",
                        column: x => x.id_municipio,
                        principalTable: "municipio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "peti",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_disponibilizacao_recurso = table.Column<string>(type: "text", nullable: false),
                    data_mes_referencia = table.Column<string>(type: "text", nullable: false),
                    situacao = table.Column<string>(type: "text", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    id_municipio = table.Column<int>(type: "integer", nullable: false),
                    id_beneficiario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_peti", x => x.id);
                    table.ForeignKey(
                        name: "fk_peti_beneficiario_peti_id_beneficiario",
                        column: x => x.id_beneficiario,
                        principalTable: "beneficiario_peti",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_peti_municipio_id_municipio",
                        column: x => x.id_municipio,
                        principalTable: "municipio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "remuneracoes_dto",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    abate_gratificacao_natalina = table.Column<string>(type: "text", nullable: false),
                    abate_gratificacao_natalina_dolar = table.Column<string>(type: "text", nullable: false),
                    abate_remuneracao_basica_bruta = table.Column<string>(type: "text", nullable: false),
                    abate_remuneracao_basica_bruta_dolar = table.Column<string>(type: "text", nullable: false),
                    existe_valor_mes = table.Column<bool>(type: "boolean", nullable: false),
                    ferias = table.Column<string>(type: "text", nullable: false),
                    ferias_dolar = table.Column<string>(type: "text", nullable: false),
                    fundo_saude = table.Column<string>(type: "text", nullable: false),
                    fundo_saude_dolar = table.Column<string>(type: "text", nullable: false),
                    gratificacao_natalina = table.Column<string>(type: "text", nullable: false),
                    gratificacao_natalina_dolar = table.Column<string>(type: "text", nullable: false),
                    imposto_retido_na_fonte = table.Column<string>(type: "text", nullable: false),
                    imposto_retido_na_fonte_dolar = table.Column<string>(type: "text", nullable: false),
                    mes_ano = table.Column<string>(type: "text", nullable: false),
                    mes_ano_por_extenso = table.Column<string>(type: "text", nullable: false),
                    outras_deducoes_obrigatorias = table.Column<string>(type: "text", nullable: false),
                    outras_deducoes_obrigatorias_dolar = table.Column<string>(type: "text", nullable: false),
                    outras_remuneracoes_eventuais = table.Column<string>(type: "text", nullable: false),
                    outras_remuneracoes_eventuais_dolar = table.Column<string>(type: "text", nullable: false),
                    pensao_militar = table.Column<string>(type: "text", nullable: false),
                    pensao_militar_dolar = table.Column<string>(type: "text", nullable: false),
                    previdencia_oficial = table.Column<string>(type: "text", nullable: false),
                    previdencia_oficial_dolar = table.Column<string>(type: "text", nullable: false),
                    remuneracao_basica_bruta = table.Column<string>(type: "text", nullable: false),
                    remuneracao_basica_bruta_dolar = table.Column<string>(type: "text", nullable: false),
                    remuneracao_empresa_publica = table.Column<bool>(type: "boolean", nullable: false),
                    sk_mes_referencia = table.Column<string>(type: "text", nullable: false),
                    taxa_ocupacao_imovel_funcional = table.Column<string>(type: "text", nullable: false),
                    taxa_ocupacao_imovel_funcional_dolar = table.Column<string>(type: "text", nullable: false),
                    valor_total_honorarios_advocaticios = table.Column<string>(type: "text", nullable: false),
                    valor_total_jetons = table.Column<string>(type: "text", nullable: false),
                    valor_total_remuneracao_apos_deducoes = table.Column<string>(type: "text", nullable: false),
                    valor_total_remuneracao_dolar_apos_deducoes = table.Column<string>(type: "text", nullable: false),
                    verbas_indenizatorias = table.Column<string>(type: "text", nullable: false),
                    verbas_indenizatorias_civil = table.Column<string>(type: "text", nullable: false),
                    verbas_indenizatorias_civil_dolar = table.Column<string>(type: "text", nullable: false),
                    verbas_indenizatorias_dolar = table.Column<string>(type: "text", nullable: false),
                    verbas_indenizatorias_militar = table.Column<string>(type: "text", nullable: false),
                    verbas_indenizatorias_militar_dolar = table.Column<string>(type: "text", nullable: false),
                    verbas_indenizatorias_referentes_pdv = table.Column<string>(type: "text", nullable: false),
                    verbas_indenizatorias_referentes_pdvdolar = table.Column<string>(type: "text", nullable: false),
                    id_honorarios_advocaticio = table.Column<int>(type: "integer", nullable: false),
                    id_jetons = table.Column<int>(type: "integer", nullable: false),
                    id_rubrica = table.Column<int>(type: "integer", nullable: false),
                    id_remuneracao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_remuneracoes_dto", x => x.id);
                    table.ForeignKey(
                        name: "fk_remuneracoes_dto_remuneracao_id_remuneracao",
                        column: x => x.id_remuneracao,
                        principalTable: "remuneracao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cnep_fundamentacao",
                columns: table => new
                {
                    cneps_id = table.Column<int>(type: "integer", nullable: false),
                    fundamentacao_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cnep_fundamentacao", x => new { x.cneps_id, x.fundamentacao_id });
                    table.ForeignKey(
                        name: "fk_cnep_fundamentacao_cnep_cneps_id",
                        column: x => x.cneps_id,
                        principalTable: "cnep",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cnep_fundamentacao_fundamentacao_fundamentacao_id",
                        column: x => x.fundamentacao_id,
                        principalTable: "fundamentacao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "honorarios_advocaticio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    mensagem_mes_referencia = table.Column<string>(type: "text", nullable: false),
                    mes_referencia = table.Column<string>(type: "text", nullable: false),
                    valor = table.Column<int>(type: "integer", nullable: false),
                    valor_formatado = table.Column<string>(type: "text", nullable: false),
                    id_remuneracoes_dto = table.Column<int>(type: "integer", nullable: false),
                    remuneracoes_dtoid1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_honorarios_advocaticio", x => x.id);
                    table.ForeignKey(
                        name: "fk_honorarios_advocaticio_remuneracoes_dto_id_remuneracoes_dto",
                        column: x => x.id_remuneracoes_dto,
                        principalTable: "remuneracoes_dto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_honorarios_advocaticio_remuneracoes_dto_remuneracoes_dtoid1",
                        column: x => x.remuneracoes_dtoid1,
                        principalTable: "remuneracoes_dto",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "jetons",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    mes_referencia = table.Column<string>(type: "text", nullable: false),
                    valor = table.Column<int>(type: "integer", nullable: false),
                    id_remuneracoes_dto = table.Column<int>(type: "integer", nullable: false),
                    remuneracoes_dtoid1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_jetons", x => x.id);
                    table.ForeignKey(
                        name: "fk_jetons_remuneracoes_dto_id_remuneracoes_dto",
                        column: x => x.id_remuneracoes_dto,
                        principalTable: "remuneracoes_dto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_jetons_remuneracoes_dto_remuneracoes_dtoid1",
                        column: x => x.remuneracoes_dtoid1,
                        principalTable: "remuneracoes_dto",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "rubrica",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    sk_mes_referencia = table.Column<string>(type: "text", nullable: false),
                    valor = table.Column<int>(type: "integer", nullable: false),
                    valor_dolar = table.Column<int>(type: "integer", nullable: false),
                    id_remuneracoes_dto = table.Column<int>(type: "integer", nullable: false),
                    remuneracoes_dtoid1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_rubrica", x => x.id);
                    table.ForeignKey(
                        name: "fk_rubrica_remuneracoes_dto_id_remuneracoes_dto",
                        column: x => x.id_remuneracoes_dto,
                        principalTable: "remuneracoes_dto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_rubrica_remuneracoes_dto_remuneracoes_dtoid1",
                        column: x => x.remuneracoes_dtoid1,
                        principalTable: "remuneracoes_dto",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_bolsa_familia_id_municipio",
                table: "bolsa_familia",
                column: "id_municipio");

            migrationBuilder.CreateIndex(
                name: "IX_bolsa_familia_id_titular",
                table: "bolsa_familia",
                column: "id_titular");

            migrationBuilder.CreateIndex(
                name: "IX_bpc_id_beneficiario",
                table: "bpc",
                column: "id_beneficiario");

            migrationBuilder.CreateIndex(
                name: "IX_bpc_id_municipio",
                table: "bpc",
                column: "id_municipio");

            migrationBuilder.CreateIndex(
                name: "IX_cepim_id_convenio",
                table: "cepim",
                column: "id_convenio");

            migrationBuilder.CreateIndex(
                name: "IX_cepim_id_orgao_superior",
                table: "cepim",
                column: "id_orgao_superior");

            migrationBuilder.CreateIndex(
                name: "IX_cepim_id_pessoa_juridica",
                table: "cepim",
                column: "id_pessoa_juridica");

            migrationBuilder.CreateIndex(
                name: "IX_cnep_id_fonte_sancao",
                table: "cnep",
                column: "id_fonte_sancao");

            migrationBuilder.CreateIndex(
                name: "IX_cnep_id_pessoa_juridica",
                table: "cnep",
                column: "id_pessoa_juridica");

            migrationBuilder.CreateIndex(
                name: "IX_cnep_id_sancionado",
                table: "cnep",
                column: "id_sancionado");

            migrationBuilder.CreateIndex(
                name: "IX_cnep_id_tipo_sancao",
                table: "cnep",
                column: "id_tipo_sancao");

            migrationBuilder.CreateIndex(
                name: "IX_cnep_orgao_sancionador_id",
                table: "cnep",
                column: "orgao_sancionador_id");

            migrationBuilder.CreateIndex(
                name: "IX_cnep_fundamentacao_fundamentacao_id",
                table: "cnep_fundamentacao",
                column: "fundamentacao_id");

            migrationBuilder.CreateIndex(
                name: "IX_fundamentacao_id_cnep",
                table: "fundamentacao",
                column: "id_cnep");

            migrationBuilder.CreateIndex(
                name: "IX_honorarios_advocaticio_id_remuneracoes_dto",
                table: "honorarios_advocaticio",
                column: "id_remuneracoes_dto");

            migrationBuilder.CreateIndex(
                name: "IX_honorarios_advocaticio_remuneracoes_dtoid1",
                table: "honorarios_advocaticio",
                column: "remuneracoes_dtoid1");

            migrationBuilder.CreateIndex(
                name: "IX_jetons_id_remuneracoes_dto",
                table: "jetons",
                column: "id_remuneracoes_dto");

            migrationBuilder.CreateIndex(
                name: "IX_jetons_remuneracoes_dtoid1",
                table: "jetons",
                column: "remuneracoes_dtoid1");

            migrationBuilder.CreateIndex(
                name: "IX_leniencia_sancoes_sancoes_id",
                table: "leniencia_sancoes",
                column: "sancoes_id");

            migrationBuilder.CreateIndex(
                name: "IX_municipio_id_uf",
                table: "municipio",
                column: "id_uf");

            migrationBuilder.CreateIndex(
                name: "IX_orgao_superior_id_orgao_maximo",
                table: "orgao_superior",
                column: "id_orgao_maximo");

            migrationBuilder.CreateIndex(
                name: "IX_peti_id_beneficiario",
                table: "peti",
                column: "id_beneficiario");

            migrationBuilder.CreateIndex(
                name: "IX_peti_id_municipio",
                table: "peti",
                column: "id_municipio");

            migrationBuilder.CreateIndex(
                name: "IX_remuneracao_id_servidor",
                table: "remuneracao",
                column: "id_servidor");

            migrationBuilder.CreateIndex(
                name: "IX_remuneracoes_dto_id_remuneracao",
                table: "remuneracoes_dto",
                column: "id_remuneracao");

            migrationBuilder.CreateIndex(
                name: "IX_rubrica_id_remuneracoes_dto",
                table: "rubrica",
                column: "id_remuneracoes_dto");

            migrationBuilder.CreateIndex(
                name: "IX_rubrica_remuneracoes_dtoid1",
                table: "rubrica",
                column: "remuneracoes_dtoid1");

            migrationBuilder.CreateIndex(
                name: "IX_sancoes_id_leniencia",
                table: "sancoes",
                column: "id_leniencia");

            migrationBuilder.CreateIndex(
                name: "IX_servidor_id_estado_exercicio",
                table: "servidor",
                column: "id_estado_exercicio");

            migrationBuilder.CreateIndex(
                name: "IX_servidor_id_funcao",
                table: "servidor",
                column: "id_funcao");

            migrationBuilder.CreateIndex(
                name: "IX_servidor_id_orgao_servidor_exercicio",
                table: "servidor",
                column: "id_orgao_servidor_exercicio");

            migrationBuilder.CreateIndex(
                name: "IX_servidor_id_orgao_servidor_lotacao",
                table: "servidor",
                column: "id_orgao_servidor_lotacao");

            migrationBuilder.CreateIndex(
                name: "IX_servidor_id_pensionista_representante",
                table: "servidor",
                column: "id_pensionista_representante");

            migrationBuilder.CreateIndex(
                name: "IX_servidor_id_pessoa_juridica",
                table: "servidor",
                column: "id_pessoa_juridica");

            migrationBuilder.CreateIndex(
                name: "IX_servidor_id_servidor_inativo_instuidor_pensao",
                table: "servidor",
                column: "id_servidor_inativo_instuidor_pensao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bolsa_familia");

            migrationBuilder.DropTable(
                name: "bpc");

            migrationBuilder.DropTable(
                name: "cepim");

            migrationBuilder.DropTable(
                name: "cnep_fundamentacao");

            migrationBuilder.DropTable(
                name: "honorarios_advocaticio");

            migrationBuilder.DropTable(
                name: "jetons");

            migrationBuilder.DropTable(
                name: "leniencia_sancoes");

            migrationBuilder.DropTable(
                name: "pep");

            migrationBuilder.DropTable(
                name: "peti");

            migrationBuilder.DropTable(
                name: "rubrica");

            migrationBuilder.DropTable(
                name: "titular_bolsa_familia");

            migrationBuilder.DropTable(
                name: "beneficiario_bpc");

            migrationBuilder.DropTable(
                name: "convenio");

            migrationBuilder.DropTable(
                name: "orgao_superior");

            migrationBuilder.DropTable(
                name: "fundamentacao");

            migrationBuilder.DropTable(
                name: "sancoes");

            migrationBuilder.DropTable(
                name: "beneficiario_peti");

            migrationBuilder.DropTable(
                name: "municipio");

            migrationBuilder.DropTable(
                name: "remuneracoes_dto");

            migrationBuilder.DropTable(
                name: "orgao_maximo");

            migrationBuilder.DropTable(
                name: "cnep");

            migrationBuilder.DropTable(
                name: "leniencia");

            migrationBuilder.DropTable(
                name: "uf");

            migrationBuilder.DropTable(
                name: "remuneracao");

            migrationBuilder.DropTable(
                name: "fonte_sancao");

            migrationBuilder.DropTable(
                name: "orgao_sancionador");

            migrationBuilder.DropTable(
                name: "sancionado");

            migrationBuilder.DropTable(
                name: "tipo_sancao");

            migrationBuilder.DropTable(
                name: "servidor");

            migrationBuilder.DropTable(
                name: "estado_exercicio");

            migrationBuilder.DropTable(
                name: "funcao");

            migrationBuilder.DropTable(
                name: "orgao_servidor_exercicio");

            migrationBuilder.DropTable(
                name: "orgao_servidor_lotacao");

            migrationBuilder.DropTable(
                name: "pensionista_representante");

            migrationBuilder.DropTable(
                name: "pessoa_juridica");

            migrationBuilder.DropTable(
                name: "servidor_inativo_instuidor_pensao");
        }
    }
}
