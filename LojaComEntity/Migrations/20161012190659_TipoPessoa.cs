using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace LojaComEntity.Migrations
{
    public partial class TipoPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_CategoriaId", table: "Produto");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Produto_ProdutoId", table: "ProdutoVenda");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Venda_VendaId", table: "ProdutoVenda");
            migrationBuilder.DropForeignKey(name: "FK_Venda_Usuario_ClienteId", table: "Venda");
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Usuario",
                nullable: false,
                defaultValue: "");
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Usuario",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "Usuario",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Produto_ProdutoId",
                table: "ProdutoVenda",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Venda_VendaId",
                table: "ProdutoVenda",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_ClienteId",
                table: "Venda",
                column: "ClienteId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_CategoriaId", table: "Produto");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Produto_ProdutoId", table: "ProdutoVenda");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Venda_VendaId", table: "ProdutoVenda");
            migrationBuilder.DropForeignKey(name: "FK_Venda_Usuario_ClienteId", table: "Venda");
            migrationBuilder.DropColumn(name: "Discriminator", table: "Usuario");
            migrationBuilder.DropColumn(name: "CPF", table: "Usuario");
            migrationBuilder.DropColumn(name: "CNPJ", table: "Usuario");
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Produto_ProdutoId",
                table: "ProdutoVenda",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Venda_VendaId",
                table: "ProdutoVenda",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_ClienteId",
                table: "Venda",
                column: "ClienteId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
